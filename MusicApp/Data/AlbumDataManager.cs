using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Data
{
    public static class AlbumDataManager
    {
        private const string DATA_FILE = "C:\\Users\\USUARIO\\source\\repos\\MusicApp\\MusicApp\\Data\\Album.json\\";

        public static Album AddAlbum(Album album)
        {
            return album;
        }

        private static string GetFileInfo()
        {
            return File.ReadAllText(DATA_FILE);
        }

        public static void SaveAlbum(Album album)
        {
            Console.WriteLine(album.Title);
            Console.WriteLine(album.Artist);
            Console.WriteLine(album.Description);
            Console.WriteLine(album.ReleasedDate);
            Console.WriteLine(album.TrackTitle);
        }  
        public static void UpdateAlbum(Album album)
        {
            Console.WriteLine(album.Title);
            Console.WriteLine(album.Artist);
            Console.WriteLine(album.Description);
            Console.WriteLine(album.ReleasedDate);
            Console.WriteLine(album.TrackTitle);
        }
        
        public static void SaveAlbumTracks(Track track) {
            Console.WriteLine(track.Title);
            Console.WriteLine(track.NumberOfTrack);
            Console.WriteLine(track.Duration);
            Console.WriteLine(track.Id);
        }
        public static void UpdateAlbumTracks(Track track)
        {
            Console.WriteLine(track.Title);
            Console.WriteLine(track.NumberOfTrack);
            Console.WriteLine(track.Duration);
            Console.WriteLine(track.Id);
        }

        public static <List> GetAll()
        {
            return new List<Album>();
        }
    }
}
