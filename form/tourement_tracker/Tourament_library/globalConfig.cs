using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourament_library
{
    public static class globalConfig
    {
        /// <summary>
        /// list of data connection
        /// </summary>
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        /// <summary>
        /// saving data either in database or text files or both
        /// </summary>
        /// <param name="dataBase"></param>
        /// <param name="textFile"></param>
        public static void InitializingConnection(bool dataBase,bool textFile)
        {
            // instead of  new List<IDataConnection>(); we can use
            // Connections = new List<IDataConnection>();

            if (dataBase)
            {
                // TODO - set up sql connection propely
                sqlConnector sql = new sqlConnector();
                Connections.Add(sql);
                
            }
            if (textFile)
            {
                // TODO - set up text file  connection propely
                textConnection text = new textConnection();
                Connections.Add(text);
            }
        }
    }
}
