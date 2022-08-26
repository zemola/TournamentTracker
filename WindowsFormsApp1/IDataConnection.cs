using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
   public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
        PersonModel CreatePerson(PersonModel model);

        TeamModel CreateTeam(TeamModel model); 

        List<PersonModel> GetPerson_All();

      


    }
}
