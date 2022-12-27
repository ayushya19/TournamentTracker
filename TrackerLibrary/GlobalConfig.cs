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
        public static List<IDataConnection> Connections { get; private set; }=new List<IDataConnection>(){ };   
        public static void InitializeConnections(bool database,bool textFiles)
        {if(database)
            {
                //TODO - Create the SQL Connection
                SQLConnector sql=new SQLConnector();
                Connections.Add(sql);
            }
        if(textFiles)
            {
                TextConnector text=new TextConnector();
                Connections.Add(text); 
                //TODO - Create the Text Connection
            }
        }


        ///<summary>
        ///Added manuall in Tracker Library
        ///<see href="https://stackoverflow.com/questions/59569075/package-type-dotnetplatform-that-is-incompatible-with-this-project"/>
        ///</summary>
        public static string cnnString(string name)
        {
            
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }


}
