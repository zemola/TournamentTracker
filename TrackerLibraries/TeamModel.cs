using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    class TeamModel
    {
        public List<PersonModel> TeamMember { get; set; } = new List<PersonModel>();
        public string TeamName { get; set; }
    }
}
