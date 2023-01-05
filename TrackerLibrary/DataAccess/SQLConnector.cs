using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SQLConnector : IDataConnection
    {
        private const string db = "Tournaments";
        //TODO - Make the CreatePrize method actually save the prize

        /// <summary>
        /// Saves a new Prize to the database
        /// </summary>
        /// <param name="model">The Prize Information</param>
        /// <returns>The Prize Information,Including the unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {

                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.placeNumber);
                p.Add("@PlaceName", model.placeName);
                p.Add("@prizeAmount", model.prizeAmount);
                p.Add("@PrizePercentage", model.prizePercentage);
                p.Add("@id", dbType: DbType.Int32,direction:ParameterDirection.Output);
                
                connection.Execute("dbo.spPrizes_Insert", param:p,commandType:CommandType.StoredProcedure);
                model.id = p.Get<int>("@id");
                return model;
            }
                
        }

        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {

                var p = new DynamicParameters();
                p.Add("@FirstName", model.firstName);
                p.Add("@LastName", model.lastName);
                p.Add("@EmailAddress", model.emailAddress);
                p.Add("@PhoneNumber", model.cellPhoneNumber);
                p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPeople_Insert", param: p, commandType: CommandType.StoredProcedure);
                model.id = p.Get<int>("@id");
                return model;
            }

        }

        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output=connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
            }
            return output;
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {

                var p = new DynamicParameters();
                p.Add("@TeamName", model.teamName);
                p.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spTeams_Insert", param: p, commandType: CommandType.StoredProcedure);
                model.id = p.Get<int>("@id");

                foreach(PersonModel tm in model.TeamMember)
                {
                    p = new DynamicParameters();
                    p.Add("@TeamId", model.id);
                    p.Add("@PersonId", tm.id);
                    
                    connection.Execute("dbo.spTeamMembers_Insert", param: p, commandType: CommandType.StoredProcedure);
                }
                return model;
            }
        }

        public List<TeamModel> GetTeam_All()
        {
            List<TeamModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<TeamModel>("dbo.spTeam_GetAll").ToList();

                foreach(TeamModel team in output)
                {
                    var p = new DynamicParameters();
                    p.Add("@TeamId", team.id); 
                    team.TeamMember = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", param: p,commandType:CommandType.StoredProcedure).ToList();
                }
            }

            return output;
        }
    }
}
