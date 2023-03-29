using BankingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{
    public interface IDataConnection
    {
        /// <summary>
        /// creates a prize model in the data source (sql or text file) and returns the ID of the prize when done 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>

        UserModel CreateUser(UserModel model);


    }
}
