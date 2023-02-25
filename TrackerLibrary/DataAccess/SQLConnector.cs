using Dapper;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SQLConnector : IDataConnection
    {
        private const string db = "Tournaments";
        //TODO - Make the CreatePrize method actually save the prize

        /// <summary>
        /// Saves a new Prize to the database
        /// </summary>
        /// <param name="model">The Prize Information</param>
        /// <returns>The Prize Information,Including the unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {

                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.placeNumber);
                p.Add("@PlaceName", model.placeName);
                p.Add("@prizeAmount", model.prizeAmount);
                p.Add("@PrizePercentage", model.prizePercentage);
                p.Add("@id", dbType: DbType.Int32,direction:ParameterDirection.Output);
                
                connection.Execute("dbo.spPrizes_Insert", param:p,commandType:CommandType.StoredProcedure);
                model.id = p.Get<int>("@id");
                return model;
            }
                
        }

        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {

                var p = new DynamicParameters();
                p.Add("@FirstName", model.firstName);
                p.Add("@LastName", model.lastName);
                p.Add("@EmailAddress", model.emailAddress);
                p.Add("@PhoneNumber", model.cellPhoneNumber);
                p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPeople_Insert", param: p, commandType: CommandType.StoredProcedure);
                model.id = p.Get<int>("@id");
                return model;
            }

        }

        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output=connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
            }
            return output;
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {

                var p = new DynamicParameters();
                p.Add("@TeamName", model.teamName);
                p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spTeams_Insert", param: p, commandType: CommandType.StoredProcedure);
                model.id = p.Get<int>("@id");

                foreach(PersonModel tm in model.TeamMember)
                {
                    p = new DynamicParameters();
                    p.Add("@TeamId", model.id);
                    p.Add("@PersonId", tm.id);
                    
                    connection.Execute("dbo.spTeamMembers_Insert", param: p, commandType: CommandType.StoredProcedure);
                }
                return model;
            }
        }

        public List<TeamModel> GetTeam_All()
        {
            List<TeamModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<TeamModel>("dbo.spTeam_GetAll").ToList();

                foreach(TeamModel team in output)
                {
                    var p = new DynamicParameters();
                    p.Add("@TeamId", team.id); 
                    team.TeamMember = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", param: p,commandType:CommandType.StoredProcedure).ToList();
                }
            }

            return output;
        }

        public TournamentModel CreateTournament(TournamentModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {

                SaveTournament(connection, model);
                SaveTournamentPrize(model, connection);
                SaveTournamentEntries(model, connection);
                SaveTournamentRound(model, connection);
                return model;
            }
        }

        private void SaveTournamentRound(TournamentModel model,IDbConnection connection)
        {
            //List<List<MatchUpRound>> Rounds
            //List<MatchupEntryModel> Entries

            // Loop through the rounds
            // Loop through the matchups
            // Save the matchups
            // Loop through the entries and save them
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    var p = new DynamicParameters();
                    p.Add("@tournamentid", model.id);
                    p.Add("@matchupround", matchup.matchUpRound);
                    p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);
                    connection.Execute("dbo.spMatchups_Insert", param: p, commandType: CommandType.StoredProcedure);
                    matchup.id = p.Get<int>("@id");

                    foreach(MatchUpEntryModel entry in matchup.entries)
                    {
                        //p.Add("@MatchupId",matchup.id);
                        
                        //if (entry.parentMatchup == null)
                        //{
                        //    p.Add("@ParentMatchupId", null);
                        //}
                        //else
                        //{
                        //    p.Add("@ParentMatchupId", entry.competingTeam.id);
                        //}
                        
                        //if(entry.competingTeam==null)
                        //{ 
                        //    p.Add("@TeamCompetingId", null);
                        //}
                        //else {
                        //    p.Add("@TeamCompetingId", entry.competingTeam.id);
                        //}
                        //p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);
                        //connection.Execute("dbo.spMatchupEntries_Insert", param: p, commandType: CommandType.StoredProcedure);
                        //matchup.id = p.Get<int>("@id");

                        p=new DynamicParameters();
                        p.Add("@MatchupId", matchup.id);
                        if(entry.parentMatchup!= null)
                        {
                        p.Add("@ParentMatchupId", entry.parentMatchup.id);
                        }
                        else
                        {
                            p.Add("@ParentMatchupId", null);
                        }
                        if (entry.competingTeam != null)
                        { p.Add("@TeamCompetingid", entry.competingTeam.id); }
                        else
                        {

                        { p.Add("@TeamCompetingid", null); }
                        }
                        p.Add("@id",0,DbType.Int32,direction:ParameterDirection.Output);

                        connection.Execute("dbo.spMatchupEntries_Insert",p,commandType: CommandType.StoredProcedure);

                    }

                }
            }
        }

        private void SaveTournamentEntries(TournamentModel model, IDbConnection connection)
        {
            foreach (TeamModel tm in model.EnteredTeam)
            {
                var p = new DynamicParameters();
                p.Add("@TournamentId", model.id);
                p.Add("@TeamId", tm.id);
                p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spTournamentEntries_Insert", param: p, commandType: CommandType.StoredProcedure);
            }
        }

        private void SaveTournamentPrize(TournamentModel model, IDbConnection connection)
        {
            foreach (PrizeModel pm in model.prizes)
            {
                var p = new DynamicParameters();
                p.Add("@TournamentId", model.id);
                p.Add("@PrizeID", pm.id);
                p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spTournamentPrizes_Insert", param: p, commandType: CommandType.StoredProcedure);
            }
        }

        private void SaveTournament(IDbConnection connection, TournamentModel model)
        {
            var p = new DynamicParameters();
            p.Add("@TournamentName", model.TournamentName);
            p.Add("@EntryFee", model.EntryFee);
            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spTournaments_Insert", p, commandType: CommandType.StoredProcedure);

            model.id = p.Get<int>("@id");
        }
    }
}
