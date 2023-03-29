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
        public static IDataConnection connection { get; private set; }

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
