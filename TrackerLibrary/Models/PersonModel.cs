using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// Unique Identifier for the prize
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Represents the first name of person
        /// </summary>
        public string firstName { get; set; }
        /// <summary>
        /// Represents the last name of person
        /// </summary>
        public string lastName { get; set; }
        /// <summary>
        /// Represents the email address of person
        /// </summary>
        public string emailAddress { get; set; }

        /// <summary>
        /// Represents the cell phone number of person
        /// </summary>
        public long cellPhoneNumber { get; set; }
    }
}
