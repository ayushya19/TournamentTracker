using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;
namespace TrackerLibrary.DataAccess
{
    // TODO - Wire up the createPrize for text files
    public class TextConnector : IDataConnection
    {
        

        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load the Text file
            // Convert the text to List<PrizeModel>

            List<PrizeModel>prizes= GlobalConfig.prizeFile.FullFilePath().LoadFile().ConvertToPrizeModel();

            // Find the ID
            int currentId = 1;
            if (prizes.Count > 0)
            {
                 currentId = prizes.OrderByDescending(x => x.id).First().id + 1;
            }
            model.id = currentId;
            // Add the new record with the new ID(max+1)
            prizes.Add(model);
            // Convert the prizes to list<string>

            // Save the list<string> to the text file
            prizes.SaveToPrizeFile(GlobalConfig.prizeFile);

            return model;
        }

        public PersonModel CreatePerson(PersonModel model)
        { 
            List<PersonModel> people = GlobalConfig.PersonFile.FullFilePath().LoadFile().ConvertToPeopleModel();
            int currentID = 1;
            if (people.Count > 0)
            {
                currentID=people.OrderByDescending(x => x.id).First().id+1;

            }
            model.id = currentID;
            people.Add(model);
            people.SaveToPeopleFile(GlobalConfig.PersonFile);
            return model;
        }

        public List<PersonModel> GetPerson_All()
        {
            return GlobalConfig.PersonFile.FullFilePath().LoadFile().ConvertToPeopleModel();
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModel(GlobalConfig.PersonFile);
            int currentID = 1;
            if (teams.Count > 0)
            {
                currentID = teams.OrderByDescending(x => x.id).First().id + 1;

            }
            model.id = currentID;
            teams.Add(model);
            teams.SaveToTeamFile(GlobalConfig.TeamFile);
            return model;
        }

        public List<TeamModel> GetTeam_All()
        {
            return GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModel(GlobalConfig.PersonFile);
        }

        public TournamentModel CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModel(GlobalConfig.TeamFile,GlobalConfig.PersonFile,GlobalConfig.prizeFile);

            // Find the ID
            int currentId = 1;
            if (tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.id).First().id + 1;
            }
            model.id = currentId;

            model.SaveRoundsToFile(GlobalConfig.MatchupFile, GlobalConfig.MatchupEntryFIle);
            // Add the new record with the new ID(max+1)
            tournaments.Add(model);
            // Convert the prizes to list<string>

            // Save the list<string> to the text file
            tournaments.SaveToTournamentFile(GlobalConfig.TournamentFile);

            return model;
        }
    }
}
