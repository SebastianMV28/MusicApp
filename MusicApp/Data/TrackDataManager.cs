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
    internal class TrackDataManager
    {
        private const string DATA_FILE = "C:\\Users\\Usuario\\Source\\Repos\\SebastianMV28\\MusicApp\\MusicApp\\Data\\Track.json";

        public static Track SaveTrack(Track track)
        {

            try
            {
                string currentTrackState = FileUtils.GetInfoFile(DATA_FILE);
                var jObject = JObject.Parse(currentTrackState);
                track.Id = $"{jObject.Properties().Count() + 1}";
                string trackJson = JsonConvert.SerializeObject(track);
                jObject.Add(track.Id, trackJson);

                string outputJson = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                FileUtils.WriteInfoFile(DATA_FILE, outputJson);

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }

            return track;
        }

        public static Track UpdateTrack(Track Track)
        {

            try
            {
                string currentTrackState = FileUtils.GetInfoFile(DATA_FILE);
                var jObject = JObject.Parse(currentTrackState);
                string trackJson = JsonConvert.SerializeObject(Track);

                jObject[$"{Track.Id}"] = trackJson;

                string outputJson = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                FileUtils.WriteInfoFile(DATA_FILE, outputJson);

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }

            return Track;
        }

        public static bool DeleteTrack(string id)
        {
            try
            {
                string currentTrackState = FileUtils.GetInfoFile(DATA_FILE);
                var jObject = JObject.Parse(currentTrackState);
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

        public static Track GetTrackById(string id)
        {

            try
            {
                string currentTrackState = FileUtils.GetInfoFile(DATA_FILE);
                var jObject = JObject.Parse(currentTrackState);
                var trackJsonStrg = (string)jObject[id];
                var valueObject = JObject.Parse(trackJsonStrg);

                return new Track(jObject)
                {
                    Id = (string)valueObject["Id"],
                    Title = (string)valueObject["Name"],
                    Album = new Album(string)valueObject["Album"],
                    Artist= (string)valueObject["Artist"],




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
