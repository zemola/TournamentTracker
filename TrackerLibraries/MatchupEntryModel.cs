using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    class MatchupEntryModel
    {
        public TeamModel Competing { get; set; }
        public double Score { get; set; }
        public MatchupModel ParentMatchup { get; set; }
    }
}
