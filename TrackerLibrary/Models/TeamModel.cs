using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        public int id { get; set; } 
        /// <summary>
        /// represents the list of members in the team
        /// </summary>
        public List<PersonModel> TeamMember { get; set; } = new List<PersonModel>();
        /// <summary>
        /// Represents the name of team
        /// </summary>
        public string teamName { get; set; }

    }
}
