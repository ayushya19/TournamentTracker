using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {/// <summary>
     /// Represent the enteries(Teams/Player) for the matchup
     /// </summary>
        public List<MatchUpEntryModel> entries { get; set; } = new List<MatchUpEntryModel>() { };
        /// <summary>
        /// Represents the team which has won the current matchup
        /// </summary>
        public TeamModel winner { get; set; }

        /// <summary>
        /// Represents the Points won after winning the current match up
        /// </summary>
        public int matchUpPoints { get; set; }
    }
}
