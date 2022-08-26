using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    class TextfileConnector : IDataConnection
    {
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 0;

            return model;
        }
    }
}
