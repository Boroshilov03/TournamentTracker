using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents the team.
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// Represents a list of each team member on the team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// Represents team name.
        /// </summary>
        public string TeamName { get; set; }
    }
}
