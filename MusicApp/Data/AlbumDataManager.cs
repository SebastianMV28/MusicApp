using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Data

    
{
    public static class AlbumDataManager
    {
        private const string DATA_FILE = "C:\\Users\\Usuario\\source\\repos\\SebastianMV28\\MusicApp\\MusicApp\\Data";

        public static Album AddAlbum(Album album)
        {
            try
            {
                string currentAlbum = GetFileInfo();
                int[] array = new int[10];
                array[0] = album.Id;

            }
            catch (IndexOutOfRangeException ex) {
                Console.ForegroundColor= char.MinValue;
            }
        };

        private static GetFileInfo() {
            return DATA_FILE 
        };
        public static void SaveAlbum(Album album)
        {
            Console.WriteLine(album.Title);
            Console.WriteLine(album.Artist);
            Console.WriteLine(album.Description);
            Console.WriteLine(album.ReleasedDate);
            Console.WriteLine(album.TrackTitle);
            Console.WriteLine(album.);
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
