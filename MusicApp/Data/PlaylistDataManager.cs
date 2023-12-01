using MusicApp.Utils;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Data
{
    internal class PlaylistDataManager
    {
        public static void SavePlaylist(Playlist playlist) => Console.WriteLine(playlist);

        private const string DATA_FILE = "C:\\Users\\Usuario\\Source\\Repos\\SebastianMV28\\MusicApp\\MusicApp\\Data\\Playlist.json";

        public static Playlist Saveplaylist(Playlist playlist)
        {

            try
            {
                string currentAuthorState = FileUtils.GetInfoFile(DATA_FILE);
                var jObject = JObject.Parse(currentAuthorState);
                playlist.Id = $"{jObject.Properties().Count() + 1}";
                string authorJson = JsonConvert.SerializeObject(playlist);
                jObject.Add(playlist.Id, authorJson);

                string outputJson = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                FileUtils.WriteInfoFile(DATA_FILE, outputJson);

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }

            return playlist;
        }

        public static Playlist UpdatePlaylist(Playlist playlist)
        {

            try
            {
                string currentAuthorState = FileUtils.GetInfoFile(DATA_FILE);
                var jObject = JObject.Parse(currentAuthorState);
                string authorJson = JsonConvert.SerializeObject(playlist);

                jObject[$"{playlist.Id}"] = authorJson;

                string outputJson = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                FileUtils.WriteInfoFile(DATA_FILE, outputJson);

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }

            return playlist;
        }

        public static bool DeletePlaylist(string id)
        {
            try
            {
                string currentAuthorState = FileUtils.GetInfoFile(DATA_FILE);
                var jObject = JObject.Parse(currentAuthorState);
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

        public static Playlist GetplaylistById(string id)
        {

            try
            {
                string currentAuthorState = FileUtils.GetInfoFile(DATA_FILE);
                var jObject = JObject.Parse(currentAuthorState);
                var authorJsonStrg = (string)jObject[id];
                var valueObject = JObject.Parse(authorJsonStrg);

                return new Playlist(jObject)
                {
                    Id = (string)valueObject["Id"],
                    PlayListName = (string)valueObject["Name"],
                    Track= (string)valueObject["Track"],


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
