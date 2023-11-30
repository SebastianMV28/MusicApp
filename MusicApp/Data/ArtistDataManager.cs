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
    public static class ArtistDataManager
    {
        private const string DATA_FILE = "C:\\Users\\Usuario\\Source\\Repos\\SebastianMV28\\MusicApp\\MusicApp\\Data\\Artist.json";
        
        public static Artist SaveArtist(Artist artist)
        {

            try
            {
                string currentAuthorState = FileUtils.GetInfoFile(DATA_FILE);
                var jObject = JObject.Parse(currentAuthorState);
                artist.Id = $"{jObject.Properties().Count() + 1}";
                string authorJson = JsonConvert.SerializeObject(artist);
                jObject.Add(artist.Id, authorJson);

                string outputJson = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                FileUtils.WriteInfoFile(DATA_FILE, outputJson);

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }

            return artist;
        }

        public static Artist UpdateArtist(Artist artist)
        {

            try
            {
                string currentAuthorState = FileUtils.GetInfoFile(DATA_FILE);
                var jObject = JObject.Parse(currentAuthorState);
                string authorJson = JsonConvert.SerializeObject(artist);

                jObject[$"{artist.Id}"] = authorJson;

                string outputJson = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                FileUtils.WriteInfoFile(DATA_FILE, outputJson);

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }

            return artist;
        }

        public static bool DeleteArtist(string id)
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

        public static Artist GetArtistById(string id)
        {

            try
            {
                string currentAuthorState = FileUtils.GetInfoFile(DATA_FILE);
                var jObject = JObject.Parse(currentAuthorState);
                var authorJsonStrg = (string)jObject[id];
                var valueObject = JObject.Parse(authorJsonStrg);

                return new Artist(jObject)
                {
                    Id = (string)valueObject["Id"],
                    Name = (string)valueObject["Name"],

                   
                    
                   
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