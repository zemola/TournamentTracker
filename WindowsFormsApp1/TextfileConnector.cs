using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    class TextfileConnector : IDataConnection
    {
        public PersonModel CreatePerson(PersonModel model)
        {
            /*model.Id = 0;*/
            return model;
        }

        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 0;

            return model;
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            throw new NotImplementedException();
        }

        public List<PersonModel> GetPerson_All()
        {
            throw new NotImplementedException();
        }

        public List<PersonModel> GetTeam_All()
        {
            throw new NotImplementedException();
        }
    }
}
