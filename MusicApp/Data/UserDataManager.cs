using MusicApp.Utils;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MusicApp.Data
{
    public static class UserDataManager
    {

        private const string  DATA_FILE = "C:\\Users\\USUARIO\\source\\repos\\MusicApp\\MusicApp\\Data\\User.json";

        public static User SaveUser(User user)
        {

            try
            {
                string currentUserState = FileUtils.GetInfoFile(DATA_FILE);
                var jObject = JObject.Parse(currentUserState);
                user.Id = $"{jObject.Properties().Count() + 1}";
                string userJson = JsonConvert.SerializeObject(user);
                jObject.Add(user.Id, userJson);

                string outputJson = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                FileUtils.WriteInfoFile(DATA_FILE, outputJson);

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }

            return user;
        }

        public static User UpdateUser(User User)
        {

            try
            {
                string currentUserState = FileUtils.GetInfoFile(DATA_FILE);
                var jObject = JObject.Parse(currentUserState);
                string UserJson = JsonConvert.SerializeObject(User);

                jObject[$"{User.Id}"] = UserJson;

                string outputJson = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                FileUtils.WriteInfoFile(DATA_FILE, outputJson);

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }

            return User;
        }

        public static bool DeleteUser(string id)
        {
            try
            {
                string currentUserState = FileUtils.GetInfoFile(DATA_FILE);
                var jObject = JObject.Parse(currentUserState);
                jObject.Remove(id);

                string outputJson = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                FileUtils.WriteInfoFile(DATA_FILE, outputJson);
                return true;

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
        }

        public static User GetUserById(string id)
        {

            try
            {
                string currentUserState = FileUtils.GetInfoFile(DATA_FILE);
                var jObject = JObject.Parse(currentUserState);
                var UserJsonStrg = (string)jObject[id];
                var valueObject = JObject.Parse(UserJsonStrg);

                return new User(jObject)
                {
                    Id = (string)valueObject["Id"],
                    Name = (string)valueObject["Name"],
                    Email = (string)valueObject["Album"],
                    TelephoneNumber = (string)valueObject["Artist"],
                    Password = (string)valueObject["Password"], 

                };

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
                return null;
            }

        }


    }
}
