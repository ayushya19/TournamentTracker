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
    {//TODO - Make the CreatePrize method actually save the prize

        /// <summary>
        /// Saves a new Prize to the database
        /// </summary>
        /// <param name="model">The Prize Information</param>
        /// <returns>The Prize Information,Including the unique identifier</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
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
    }
}
