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
        private const string prizeFiles = "PrizeModel.csv";
        private const string PersonFiles = "PersonModel.csv";
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load the Text file
            // Convert the text to List<PrizeModel>

            List<PrizeModel>prizes=prizeFiles.FullFilePath().LoadFile().ConvertToPrizeModel();

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
            prizes.SaveToPrizeFile(prizeFiles);

            return model;
        }

        public PersonModel CreatePerson(PersonModel model)
        { 
            List<PersonModel> people = PersonFiles.FullFilePath().LoadFile().ConvertToPeopleModel();
            int currentID = 1;
            if (people.Count > 0)
            {
                currentID=people.OrderByDescending(x => x.id).First().id+1;

            }
            model.id = currentID;
            people.Add(model);
            people.SaveToPeopleFile(PersonFiles);
            return model;
        }
    }
}
