using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    class SqlConnector : IDataConnection
    {
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
