using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BankingLibrary
{
    public static class GlobalConfig
    {
        /// <summary>
        /// allows other parts of the application to access connection property to have access to the connection type
        /// </summary>
        public static IDataConnection connection { get; private set; }


        /// <summary>
        /// this makes the application alot flexible by allowing the user to choose the type of connection they want to use either textfile or sql
        /// </summary>
        /// <param name="connectiontype"></param>
        public static void InitializeConnections(string connectiontype)
        {


           if (connectiontype == "textfile")
            {
                TextFileConnector textfile = new TextFileConnector();
                connection = textfile;
            }
        }
    }
}
