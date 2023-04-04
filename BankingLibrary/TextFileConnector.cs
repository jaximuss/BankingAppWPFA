using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{
    public class TextFileConnector : IDataConnection
    {
        private const string UserFile = "UserModel.csv";

       

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


    }

}
