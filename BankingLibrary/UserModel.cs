using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{
    public class UserModel
    {
        /// <summary>
        /// id of the user
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// firstname of the user
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// last name of the user
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// email address of the user
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// password of the user
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// username of the user
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// money of the user
        /// </summary>
        public int Money { get; set; }


        /// <summary>
        /// empty ctor no parameter
        /// </summary>
        public UserModel() { }


        /// <summary>
        /// set values of each property
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="emailAddress"></param>
        /// <param name="password"></param>
        /// <param name="username"></param>
        public UserModel(string firstName, string lastName, string emailAddress, string password, string username)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Password = password;
            UserName = username;

        }
    }
}
