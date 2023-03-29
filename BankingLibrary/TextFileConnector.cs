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

            users.Add(user);

            users.SaveToUserFile(UserFile);

            return user;
        }

       
    }

}
