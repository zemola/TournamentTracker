using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
   public class PrizeModel
    {
        public int Id { get; set; }
        public int PlaceNumber { get; set; }
        public string PlaceName { get; set; }
        public decimal PrizeAmount  { get; set; }
        public double Percentage { get; set; }
    }
}
