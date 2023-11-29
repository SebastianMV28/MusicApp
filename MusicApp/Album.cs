using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    public class Album
    {
        private int _id;
        private string  _title, _description;
        private Artist _artist;
        private Track _trackTitle;
        private DateTime _releasedDate;
        private MusicGenre _musicGenre;
        public int Id { get { return _id; } set { _id = value; } }
        public Artist Artist{ get { return _artist; } set { _artist = value; } }
        public string Title { get { return _title; } set { _title = value; } }
        public string Description { get {return _description; } set { _description = value; } }
        public DateTime ReleasedDate { get { return _releasedDate; } set { _releasedDate= value;} }
        public Track TrackTitle { get { return _trackTitle; } set { _trackTitle = value; } }
        public MusicGenre MusicGenre { get { return _musicGenre; } set { _musicGenre = value; } }

        public Album(JObject valueObject)
        {
            var album = valueObject["Album"].ToObject<JObject>();
            Id = (int)valueObject["Id"];
            Title = (string)valueObject["Title"];
            Description = (string)valueObject["Description"];
            Artist = new Artist(artist);
            TrackTitle = new Track(track);
            ReleasedDate = (DateTime)valueObject["Released Data"];
            MusicGenre = new MusicGenre(musicGenre);
            

            
        }

        public Album( string title, Artist artist, Track trackTitle, DateTime releasedDate )
        {
            _title = title;
            _artist = artist;
            _trackTitle = trackTitle;
            _releasedDate = releasedDate;

        }
    }
}
