using System;
using System.Collections.Generic;
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
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.cnnString("Tournaments")))
                
        }
    }
}
