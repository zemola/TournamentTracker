using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {

        public static IDataConnection Connection { get; private set; }
        public static void InitializeConnections(DatabaseType db)
        {
            if(db == DatabaseType.Sql)
            {
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }

            if(db == DatabaseType.TextFile)
            {
                TextfileConnector textfile = new TextfileConnector();
                Connection = textfile;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
