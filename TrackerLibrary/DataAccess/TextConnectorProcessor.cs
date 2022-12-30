using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
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

    }
}
