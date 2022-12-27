using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {/// <summary>
     /// Represents the name of the tournament
     /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the entry fee for the tournament
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents the list of teams that that has taken part in the current tournament
        /// </summary>
        public List<TeamModel> EnteredTeam { get; set; } = new List<TeamModel>() { };
        /// <summary>
        /// Represents list of prize for the current Tournament
        /// </summary>
        public List<PrizeModel> prizes { get; set; } = new List<PrizeModel>() { };
        /// <summary>
        /// Represents the list of list of Matchups in this current tournament
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>() { };

    }
}
