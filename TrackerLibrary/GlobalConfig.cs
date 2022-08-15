using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {

        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnection(bool Database, bool Textfile)
        {
            if(Database == true)
            {
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if(Textfile == true)
            {
                TextfileConnector textfile = new TextfileConnector();
                Connections.Add(textfile);
            }
        }
    }
}
