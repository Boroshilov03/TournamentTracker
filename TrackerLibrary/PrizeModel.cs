using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents the price.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Represents the place number won
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the place name
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Represents the prize amount won
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Represents the prize percentage won
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
