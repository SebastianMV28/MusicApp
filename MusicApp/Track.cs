using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    public class Track
    {
        private int _id;
        private string _title;
        private TimeOnly _duration;
        private Artist _artist;
        private Album _album;
        private int _numberOfTrack;



        public int Id { get => _id; set => _id = value; }
        public string Title { get => _title; set => _title = value; }
        public TimeOnly Duration { get => _duration; set => _duration = value; }
        public Artist Artist { get => _artist; set => _artist = value; }
        public Album Album { get => _album; set => _album = value; }
        public int NumberOfTrack { get => _numberOfTrack;  set => _numberOfTrack = value; }



        public Track(string title, int numberOfTrack, TimeOnly duration ) 
        {
            _title = title;
            _numberOfTrack = numberOfTrack;
            _duration = duration;
        }
        public Track(Artist artist, Album album) 
        {
            _artist = artist;
            _album = album;
        }
    }
}
