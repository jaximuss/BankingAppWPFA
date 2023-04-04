using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Runtime.CompilerServices;
using System.IO;

namespace BankingLibrary
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            //C:\Users\chidi\OneDrive\Desktop\BankWFA\BankingAppWPFA\savefiles"/>
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }

        public static List<UserModel> ConvertToUserModel(this List<string> lines)
        {
            List<UserModel> output = new List<UserModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                UserModel model = new UserModel();
                model.Id = int.Parse(cols[0]);
                model.FirstName = cols[1];
                model.LastName = cols[2];
                model.EmailAddress = cols[3];
                model.Password = cols[4];
                model.UserName = cols[5];
                model.Money = int.Parse(cols[6]);
                

                output.Add(model);
            }
            return output ;
        }

        public static void SaveToUserFile(this List<UserModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (var p in models)
            {
                lines.Add($"{ p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.Password},{p.UserName},{p.Money}" );
            }
            File.WriteAllLines(fileName.FullFilePath(), lines) ;
        }
    }
   
}
 