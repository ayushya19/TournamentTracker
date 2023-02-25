﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TrackerLibrary.Models;


// Load the Text file
// Convert the text to List<PrizeModel>
// Find the ID
// Add the new record with the new ID(max+1)
// Convert the prizes to list<string>
// Save the list<string> to the text file

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["FilePath"]}\\{fileName}";
        }
        public static List<String> LoadFile(this string file)
        {
            if(!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList() ;   
        }

        public static List<PrizeModel> ConvertToPrizeModel(this List<string> lines)
        {
            List<PrizeModel> output=new List<PrizeModel>(); 
            foreach(string line in lines) 
            {
                string[] cols=line.Split(',');
                PrizeModel p=new PrizeModel();
                p.id = int.Parse(cols[0]);
                p.placeNumber = int.Parse(cols[1]);
                p.placeName = cols[2];
                p.prizeAmount = decimal.Parse(cols[0]);
                p.prizePercentage = double.Parse(cols[0]);
                output.Add(p);


            }
            return output ;
        }

        public static void SaveToPrizeFile(this List<PrizeModel> models,string filename)
        {
            List<string> lines = new List<string>();

            foreach(PrizeModel p in models)
            {
                lines.Add($"{p.id},{ p.placeNumber},{p.placeName},{p.prizeAmount},{p.prizePercentage}");
            }
            File.WriteAllLines(filename.FullFilePath(), lines);
        }







        //--------------------------------------------------PERSON MODEL-----------------------------------------------------------------
        public static List<PersonModel> ConvertToPeopleModel(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PersonModel p = new PersonModel();
                p.id = int.Parse(cols[0]);
                p.firstName = cols[1];
                p.lastName = cols[2];
                p.emailAddress = cols[0];
                p.cellPhoneNumber = int.Parse(cols[0]);
                output.Add(p);


            }
            return output;
        }

        public static void SaveToPeopleFile(this List<PersonModel> models, string filename)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                lines.Add($"{p.id},{p.firstName},{p.lastName},{p.emailAddress},{p.cellPhoneNumber}");
            }
            File.WriteAllLines(filename.FullFilePath(), lines);
        }


        //--------------------------------------------------Team MODEL-----------------------------------------------------------------
        public static List<TeamModel> ConvertToTeamModel(this List<string> lines, string peopleFileName)
        {
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPeopleModel();
            foreach (string line in lines)
            {
                //id,team name,list of ids seperated by the pipe
                //3,Tim's Team,1|3|5
                string[] cols = line.Split(',');
                TeamModel tm = new TeamModel();
                tm.id = int.Parse(cols[0]);
                tm.teamName = cols[1];
                string[] personIds = cols[2].Split('|');

                foreach (string id in personIds)
                {
                    tm.TeamMember.Add(people.Where(x => x.id == int.Parse(id)).First());
                }
                output.Add(tm);

            }
            return output;
        }

        public static void SaveToTeamFile(this List<TeamModel> models,string filename) 
        {
            List<string> lines = new List<string>();
            foreach (TeamModel tm in models)
            {
                lines.Add($"{tm.id},{tm.teamName},{ConvertPeopleListToString(tm.TeamMember)}");
            }
            File.WriteAllLines(filename.FullFilePath(),lines);
        }

        private static string ConvertPeopleListToString(List<PersonModel> people)
        {
            string output = "";
            //2|5|
            if(people.Count==0)
            { return ""; }
            foreach(PersonModel p in people)
            {
                output += $"{p.id}|";
            }
            output= output.Substring(0,output.Length-1);
            return output;  
        }

        //--------------------------------------------------Tournament MODEL-----------------------------------------------------------------
        public static List<TournamentModel> ConvertToTournamentModel(this List<string> lines,string teamFileName,string peopleFileName,string prizeFileName)
        {
            //id,tournamentName,EntryFee,(id|id|id - Entered Teams),(id|id|id| - Prize),(Rounds- id^id^id|id^id^id|id^id^id)
            
            List<TournamentModel> output=new List<TournamentModel>();
            List<TeamModel> teams = teamFileName.FullFilePath().LoadFile().ConvertToTeamModel(peopleFileName);
            List<PrizeModel> prize = prizeFileName.FullFilePath().LoadFile().ConvertToPrizeModel();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TournamentModel tm= new TournamentModel();
                tm.id = int.Parse(cols[0]);
                tm.TournamentName = cols[1];
                tm.EntryFee= int.Parse(cols[2]);
                string[] teamIds= cols[3].Split("|");
                foreach(string id in teamIds)
                {
                    tm.EnteredTeam.Add(teams.Where(x => x.id == int.Parse(id)).First());
                }

                string[] prizeIds = cols[4].Split("|");

                foreach (string id in teamIds)
                {
                    tm.EnteredTeam.Add(teams.Where(x => x.id == int.Parse(id)).First());
                }

                //TODO - Capturing Round Informations

                output.Add(tm);
            }
            return output;
            
        }

        


        public static void SaveToTournamentFile(this List<TournamentModel> models, string filename)
        {
            List<string> lines = new List<string>();

            foreach (TournamentModel tm in models)
            {
                lines.Add($@"{tm.id},
                             {tm.TournamentName},
                             {tm.EntryFee},
                             {tm.EntryFee},
                             {ConvertTeamListToString(tm.EnteredTeam)},
                             {ConvertPrizeListToString(tm.prizes)},
                             {""}");
            }
            File.WriteAllLines(filename.FullFilePath(), lines);
        }

        private static string ConvertPrizeListToString(List<PrizeModel> prizes)
        {
            string output = "";
            //2|5|
            if (prizes.Count == 0)
            { return ""; }
            foreach (PrizeModel p in prizes)
            {
                output += $"{p.id}|";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string ConvertTeamListToString(List<TeamModel> teams)
        {
            string output = "";
            //2|5|
            if (teams.Count == 0)
            { return ""; }
            foreach (TeamModel t in teams)
            {
                output += $"{t.id}|";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string ConvertRoundsListToString(List<List<MatchupModel>> rounds)
        {
            //(Rounds - id ^ id ^ id | id ^ id ^ id | id ^ id ^ id)
            string output = "";
            //2|5|
            if (rounds.Count == 0)
            { return ""; }
            foreach (List<MatchupModel> round in rounds)
            {
                output += $"{ConvertMatchupListToString(round)}|";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }
        

        private static string ConvertMatchupListToString(List<MatchupModel> matchUps)
        {
            //(Rounds - id ^ id ^ id | id ^ id ^ id | id ^ id ^ id)
            string output = "";
            //2|5|
            if (matchUps.Count == 0)
            { return ""; }
            foreach (MatchupModel matchup in matchUps)
            {
                output += $"{matchup.id}^";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }


        public static List<MatchUpEntryModel> ConvertToMatchUpEntryModel(this List<string> lines)
        {
            List<MatchUpEntryModel> output = new List<MatchUpEntryModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                MatchUpEntryModel me = new MatchUpEntryModel();
                me.Id = int.Parse(cols[0]);
                me.competingTeam = LookupTeamById(int.Parse(cols[1]));
                me.score =int.Parse(cols[2]);
                int parentId = 0;
                if (int.TryParse(cols[3], out parentId))
                {

                me.parentMatchup =LookMatchupById(int.Parse( cols[0]));
                }
                else
                {
                    me.parentMatchup = null;
                }
                
                output.Add(me);


            }
            return output;
        }

        private static List<MatchUpEntryModel> ConvertStringToMatchupEntryModel(string input)
        {
            //id=0,teamid=0,score=100,matchupid

            string[] ids=input.Split('|');
            List<MatchUpEntryModel> outputs=new List<MatchUpEntryModel>();
            List<MatchUpEntryModel> entries=GlobalConfig.MatchupEntryFIle.FullFilePath().LoadFile().ConvertToMatchUpEntryModel();
            foreach (string id in ids)
            {
                outputs.Add(entries.Where(x=>x.Id==int.Parse(id)).First());
            }

            return outputs;
            
        }

        private static TeamModel LookupTeamById(int id)
        {
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModel(GlobalConfig.PersonFile);
            return teams.Where(x => x.id == id).First();
            
        }

        private static MatchupModel LookMatchupById(int id)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModel();
            return matchups.Where(x=>x.id== id).First();    

        }

        public static List<MatchupModel> ConvertToMatchupModel(this List<string> lines)
        {//id=0,entries=1(pipe delimitation by id),winner=2,matchupRound=3
            List<MatchupModel> output = new List<MatchupModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                MatchupModel p = new MatchupModel();
                p.id = int.Parse(cols[0]);
                p.entries = ConvertStringToMatchupEntryModel(cols[1]); ;
                p.winner = LookupTeamById(int.Parse(cols[2]));
                p.matchUpRound = int.Parse(cols[3]);
                output.Add(p);


            }
            return output;
        }
        public static void SaveRoundsToFile(this TournamentModel model,string path,string matchUpFile)
        {
            //Loop Through Each Round
            //Loop Through each matchup
            //Get the id for the new matchup and save the world
            //Loop through each entry ,get the id, and save it

            foreach(List<MatchupModel> round in model.Rounds)
            {
                foreach(MatchupModel matchup in round)
                {
                    //Load all the matchups from file
                    //Get the top id and add one
                    //Store the id
                    //Save the matchup record
                    matchup.SaveMatchupToFile(matchUpFile);
                }
            }
        }

        public static void SaveMatchupToFile(this MatchupModel matchup,string matchupEntryFile)
        {
            int currentid = 1;
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModel();

            foreach(MatchUpEntryModel entry in matchup.entries)
            {
                entry.SaveEntryToFile(matchupEntryFile);
            }
        }

        public static void SaveEntryToFile(this MatchUpEntryModel entry,string matchupEntryFile)
        {

        }
    }

    





}
