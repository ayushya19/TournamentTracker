using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {

        //TODO - Wire Our MAtchup
        //Order Our list Randomly of teams
        //Check if it is big enouth, if not enough, add in byes 2*2*2*2 - 2**4
        // Create our first round of matchup
        //create every round after that 8-matchups,4-matchups,2-matchups,1-matchup

        public static void CreateRounds(TournamentModel model)
        {
            List<TeamModel> randomizedTeam = RandomizeTeamOrder(model.EnteredTeam);
            int rounds = FindNumberOfRounds(randomizedTeam.Count);
            int byes = NumberOfByes(rounds, randomizedTeam.Count);
            model.Rounds.Add(CreateFirstRound(byes,randomizedTeam));
            CreateOtherRounds(model, rounds);
        }

        private static void CreateOtherRounds(TournamentModel model,int rounds)
        {
            int round = 2;
            List<MatchupModel> previousRounds = model.Rounds[0];
            List<MatchupModel> currRound = new List<MatchupModel>();
            MatchupModel currMatchup = new MatchupModel();

            while (round <= rounds)
            {
                foreach (MatchupModel match in previousRounds)
                {
                    currMatchup.entries.Add(new MatchUpEntryModel { parentMatchup = match });
                    if(currMatchup.entries.Count>1)
                    {
                        currMatchup.matchUpRound=round;
                        currRound.Add(currMatchup);
                        currMatchup=new MatchupModel();
                    }
                }
                model.Rounds.Add(currRound);
                previousRounds = currRound;
                currRound=new List<MatchupModel>();
                round += 1;
            }
        }
        public static List<MatchupModel> CreateFirstRound(int byes,List<TeamModel> teams)
        {
            List <MatchupModel> result = new List<MatchupModel>();
            MatchupModel curr=new MatchupModel();
            foreach(TeamModel team in teams)
            {
                curr.entries.Add(new MatchUpEntryModel { competingTeam = team });

                if(byes>0|| curr.entries.Count>1)
                {
                    curr.matchUpRound = 1;
                    result.Add(curr);
                    curr=new MatchupModel();
                    if(byes> 0)
                    {
                        byes--;
                    }
                }
            }
            return result;
        }
        public static int NumberOfByes(int rounds,int numberOfTeams)
        {
            int output = 0;
            int totalTeams = 1;
            for(int i=1;i<=rounds;i++)
            {
                totalTeams *= 2;
            }
            output = totalTeams - numberOfTeams;
            return output;
        }
        private static int FindNumberOfRounds(int teamCount)
        { //29

            int output = 1;
            int val = 2;
            while(val<teamCount)//29
            {
                output += 1;//1,2,3,4
                val *= 2;//2,4,16,32
            }

            return output;
            
        }
        private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
        {
            return teams.OrderBy(x => Guid.NewGuid()).ToList();      
        }
    }
}
