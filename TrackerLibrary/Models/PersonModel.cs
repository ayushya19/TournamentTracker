using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {/// <summary>
     /// Represents the first name of person
     /// </summary>
        public int firstName { get; set; }
        /// <summary>
        /// Represents the last name of person
        /// </summary>
        public int lastName { get; set; }
        /// <summary>
        /// Represents the email address of person
        /// </summary>
        public int emailAddress { get; set; }

        /// <summary>
        /// Represents the cell phone number of person
        /// </summary>
        public int cellPhoneNumber { get; set; }
    }
}
