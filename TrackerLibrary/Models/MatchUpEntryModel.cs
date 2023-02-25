using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{

    public class MatchUpEntryModel
    {
        /// <summary>
        /// Represents One team in the Matchup
        /// </summary>
        
        public int Id { get; set; }


        /// <summary>
        /// Represents One team in the Matchup
        /// </summary>
        public TeamModel competingTeam { get; set; }

        /// <summary>
        ///    Represents the score for this particular team
        /// </summary>

        public int score { get; set; }

        /// <summary>
        ///    Represents the matchup this team came 
        ///    from as the winner
        /// </summary>

        public MatchupModel parentMatchup { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="initialScore">
        /// <
        /// </param>



    }
}
