using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;
using System.Configuration;
namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; } 
        public static void InitializeConnections(DatabaseType connectionType)
        {
            
            if(connectionType==DatabaseType.Sql)
            {
                //TODO - Create the SQL Connection
                SQLConnector sql=new SQLConnector();
                Connection=sql;
            }
            if(connectionType == DatabaseType.TextFile) 
            {
                TextConnector text = new();
                Connection=text; 
                //TODO - Create the Text Connection
            }
        }


        ///<summary>
        ///Added manuall in Tracker Library
        ///<see href="https://stackoverflow.com/questions/59569075/package-type-dotnetplatform-that-is-incompatible-with-this-project"/>
        ///</summary>
        public static string CnnString(string name)
        {
            
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }


}
