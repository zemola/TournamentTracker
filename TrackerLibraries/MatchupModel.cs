using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    class MatchupModel
    {
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        public TeamModel Winner { get; set; }

        public int MatchupRound { get; set; }
    }
}
