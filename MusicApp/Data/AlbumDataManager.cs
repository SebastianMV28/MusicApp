﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Data
{
    internal class AlbumDataManager
    {

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