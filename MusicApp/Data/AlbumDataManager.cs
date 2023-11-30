using MusicApp;
using MusicApp.Utils;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MusicApp.Data
{
    public class AlbumDataManager
    {
        private const string DATA_FILE = "C:\\Users\\USUARIO\\source\\repos\\MusicApp\\MusicApp\\Data\\Album.json\\";
        
        public static Album AddAlbum(Album album)
        {

            try
            {
                string currentAlbumState = FileUtils.GetInfoFile(DATA_FILE);
                var jObject = JObject.Parse(currentAlbumState);
                album.Id = $"{jObject.Properties().Count() + 1}";
                string albumJson = JsonConvert.SerializeObject(album);
                jObject.Add(album.Id, albumJson);
                string outputJson = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                FileUtils.WriteInfoFile(DATA_FILE, outputJson);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }

            return album;
        }
        public static Album GetAlbumById(string id)
        {

            try
            {
                string currentAlbumState = FileUtils.GetInfoFile(DATA_FILE);
                var jObject = JObject.Parse(currentAlbumState);
                var albumJsonStrg = (string)jObject[id];
                var valueObject = JObject.Parse(albumJsonStrg);

                return new Album(valueObject);

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
                return null;
            }

        }


        public static void SaveAlbum(Album album)
        {
            Console.WriteLine(album.Title);
            Console.WriteLine(album.Artist);
            
            Console.WriteLine(album.ReleasedDate);
            Console.WriteLine(album.TrackTitle);
        }
        public static void UpdateAlbum(Album album)
        {
            Console.WriteLine(album.Title);
            Console.WriteLine(album.Artist);
            
            Console.WriteLine(album.ReleasedDate);
            Console.WriteLine(album.TrackTitle);
        }

        public static void SaveAlbumTracks(Track track)
        {
            Console.WriteLine(track.Title);
            
            Console.WriteLine(track.Duration);
            Console.WriteLine(track.Id);
        }
        public static void UpdateAlbumTracks(Track track)
        {
            Console.WriteLine(track.Title);
            
            Console.WriteLine(track.Duration);
            Console.WriteLine(track.Id);
        }

  
    }  
}

