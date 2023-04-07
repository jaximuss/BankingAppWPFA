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
        /// <summary>
        /// takes the fullfile path from the app settings and returns the file name
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string FullFilePath(this string fileName)
        {
            //C:\Users\chidi\OneDrive\Desktop\BankWFA\BankingAppWPFA\savefiles"/>
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }


        /// <summary>
        /// checks the file to see if it exists and returns a list of strings
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }


        /// <summary>
        /// reads the file and converts the data to a list of usermodel
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
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

        /// <summary>
        /// takes the list of usermodel and saves it to the file whilst arranging the data in the correct format
        /// </summary>
        /// <param name="models"></param>
        /// <param name="fileName"></param>
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
 