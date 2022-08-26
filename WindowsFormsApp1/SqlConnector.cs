using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace TrackerLibrary
{
    class SqlConnector : IDataConnection
    {
        private const string db = "Tournament";
        public PersonModel CreatePerson(PersonModel model)
         
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("FirstName", model.FirstName);
                p.Add("LastName", model.LastName);
                p.Add("Email", model.Email);
                p.Add("PhoneNumber", model.PhoneNumber);

                connection.Execute("dbo.spPeople_INSERT", p, commandType: CommandType.StoredProcedure);
            }
            return model;
        }


        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("PlaceName", model.PlaceName);
                p.Add("placeNumber", model.PlaceNumber);
                p.Add("PrizeAmount", model.PrizeAmount);
                p.Add("PrizePercerntage", model.Percentage);

                connection.Execute("dbo.spPrizes_INSERT", p, commandType: CommandType.StoredProcedure);

            }

            return model;
        }

        public TeamModel CreateTeam(TeamModel model)
        {
           using (IDbConnection connection = new System.Data.SqlClient.SqlConnection (GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@TeamName", model.TeamName);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output); ;

                connection.Execute("dbo.spTeams_INSERT",p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                foreach ( PersonModel tm  in model.TeamMember)
                {
                    p = new DynamicParameters();
                    p.Add("@TeamId", model.Id);
                    p.Add("personId", tm.Id);

                    connection.Execute("dbo.spTeamMembers_INSERT", p, commandType: CommandType.StoredProcedure);
                }
            }
            return model;
        }

        public List<PersonModel> GetPerson_All()
        {

            List<PersonModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<PersonModel>("dbo.spPerson_GET").AsList();
            }

            return output;

        }

        public List<TeamModel> GetTeam_All()
        {
            List<TeamModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<TeamModel>("dbo.spPerson_GET").AsList();
                foreach (TeamModel team in output)
                {
                    team.TeamMember = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam").AsList();
                }
            }

            return output;

        }
    }
}
