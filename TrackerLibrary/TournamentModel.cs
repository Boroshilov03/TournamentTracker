using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents name for the tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represents amount of money to enter the tournament
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// List of team names entered the tournaments
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Represents the list of prizes for particular tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
