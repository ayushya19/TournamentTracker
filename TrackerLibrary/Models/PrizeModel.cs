using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// Unique Identifier for the prize
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Represents the place in ranking
        /// </summary>
        public int placeNumber { get; set; }
        /// <summasry>
        /// Represents the name of the place in ranking
        /// </summary>
        public string placeName { get; set; }

        /// <summary>
        /// Represents the amount won in this place
        /// </summary>
        public decimal prizeAmount { get; set; }
        /// <summary>
        /// Represents the percentage of total prize
        /// </summary>
        public double prizePercentage { get; set; }

        public PrizeModel()
        { }

        public PrizeModel(string placeNumber, string placeName, string prizeAmount, string prizePercentage)
        {
            this.placeName = placeName;

            int PlaceNumberValue = 0;
            int.TryParse(placeNumber, out PlaceNumberValue);
            this.placeNumber = PlaceNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            this.prizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            this.prizePercentage = prizePercentageValue;
        }
    }



}
