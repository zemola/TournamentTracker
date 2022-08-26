using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
   public class TeamModel
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public List<PersonModel> TeamMember { get; set; } = new List<PersonModel>();
    }
}
