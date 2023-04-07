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
        /// method is used to create a new user and returns a UserModel object containing the details of the newly created user.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        UserModel CreateUser(UserModel model);

        /// <summary>
        ///  method takes in two parameters username and password and returns a UserModel object after validating the user's credentials.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        UserModel Login(string username, string password);


        /// <summary>
        /// method takes a UserModel object as a parameter and returns the account balance of the user as an integer.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        int CheckBalance(UserModel user);


        /// <summary>
        /// method takes a UserModel object and an integer amount as parameters and deposits the specified amount into the user's account. 
        /// It also returns the updated account balance as an integer
        /// </summary>
        /// <param name="user"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        int Deposit(UserModel user, int amount);


        /// <summary>
        /// method takes a UserModel object and an integer amount as parameters and transfers the specified amount from the user's account to another account.
        /// It also returns the updated account balance as an integer
        /// </summary>
        /// <param name="user"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        int Transfer(UserModel user, int amount);
    }
}
