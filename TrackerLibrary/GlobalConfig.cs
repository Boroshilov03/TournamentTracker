using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        //private set - only methods inside of this Global Config class can change, but everyone can read the value
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        //List bcz we may have the option of saving to a text file and the database - 1 or more data sources
        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database) // == true
            {
                //TODO - Create the SQL Connection/Set up the SQL Connection
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
            if (textFiles)
            {
                //TODO - Create the Text Connection
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }
    }
}
