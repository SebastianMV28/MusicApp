using MusicApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;

namespace MusicApp.Data
{
    public static class UserDataManager
    {

        private const string  DATA_FILE = "C:\\Users\\USUARIO\\source\\repos\\MusicApp\\MusicApp\\Data";

        public static string GetInfoFile() {
            return DATA_FILE; 
        }

        public static User SaveUser(User user)
        {
            try
            {
                string currentUserState = FileUtils.GetInfoFile(DATA_FILE);
                var jObject = JObject.Parse(currentUserState);
                string userJson = JsonConverter.SerializeObject(user);

                jObject[$"{user.Id}"] = userJson;

                string outputJson = JsonConverter.SerializeObject(jObject, Formatting.Indented);
                return user;

                


            }catch {

            }
        }


    }
}
