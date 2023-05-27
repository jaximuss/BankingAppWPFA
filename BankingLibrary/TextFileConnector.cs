using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{
    /// <summary>
    /// all methods and logic to the textfile
    /// </summary>
    public class TextFileConnector : IDataConnection
    {
        /// <summary>
        /// the name of the textfile
        /// </summary>
        private const string UserFile = "UserModel.csv";

       
        /// <summary>
        /// creates the model gives the user an ID and money
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public UserModel CreateUser(UserModel user)
        {
           List<UserModel> users =  UserFile.FullFilePath().LoadFile().ConvertToUserModel();
            int currentId = 1;

            if (users.Count >0)
            {
                currentId = users.OrderByDescending(x => x.Id).First().Id + 1;
            }
            user.Id = currentId;

            user.Money = 1000;

            users.Add(user);

            users.SaveToUserFile(UserFile);

            return user;
        }

        public UserModel Login(string username, string password)
        {
            List<UserModel> users = UserFile.FullFilePath().LoadFile().ConvertToUserModel();

            UserModel user = users.FirstOrDefault(u => u.UserName == username && u.Password == password);
            

            return user;
        }

        public int CheckBalance(UserModel user)
        {
            List<UserModel> users = UserFile.FullFilePath().LoadFile().ConvertToUserModel();

            UserModel currentUser = users.FirstOrDefault(u => u.Id == user.Id);

            if (currentUser == null)
            {
                throw new Exception($"User with id {user.Id} not found");
            }

            return currentUser.Money;
        }


        /// <summary>
        /// adds money to the current account
        /// </summary>
        /// <param name="user"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public int Deposit(UserModel user, int amount)
        {
            List<UserModel> users = UserFile.FullFilePath().LoadFile().ConvertToUserModel();

            UserModel currentUser = users.FirstOrDefault(u => u.Id == user.Id);

            if (currentUser == null)
            {
                throw new Exception($"User with id {user.Id} not found");
            }
            currentUser.Money += amount;
            users.SaveToUserFile(UserFile);

            return currentUser.Money;
        }

        /// <summary>
        /// just removes money from the current account
        /// </summary>
        /// <param name="user"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public int Transfer(UserModel user, int amount)
        {
            List<UserModel> users = UserFile.FullFilePath().LoadFile().ConvertToUserModel();

            UserModel currentUser = users.FirstOrDefault(u => u.Id == user.Id);

            if (currentUser == null)
            {
                throw new Exception($"User with id {user.Id} not found");
            }
            currentUser.Money -= amount;
            users.SaveToUserFile(UserFile);

            return currentUser.Money;
        }

    }

}
