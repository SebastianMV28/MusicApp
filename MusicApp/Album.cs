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
        private string _id;
        private string  _title, _description;
        private Artist _artist;
        private Track _trackTitle;
        private Track _numberOfTrack;
        private DateTime _releasedDate;
        private MusicGenre _musicGenre;
        public Artist Artist{ get { return _artist; } set { _artist = value; } }
        public string Title { get { return _title; } set { _title = value; } }
        public string Description { get {return _description; } set { _description = value; } }
        public DateTime ReleasedDate { get { return _releasedDate; } set { _releasedDate= value;} }
        public Track NumberOfTrack{ get { return _numberOfTrack; } set { _numberOfTrack = value; } }
        public Track TrackTitle { get { return _trackTitle; } set { _trackTitle = value; } }

        public MusicGenre MusicGenreSelection { get { return _musicGenre; } set { _musicGenre = value; } }

        public string Id { get => _id; set => _id = value; }

        public Album(JObject valueObject)
        {
            var album = valueObject["Album"].ToObject<JObject>();

            Id = (string)valueObject["Id"];
            Title = (string)valueObject["Title"];
            Description = (string)valueObject["Description"];
            Artist = new Artist(artist);
            NumberOfTrack = (Track)valueObject["Number Of Track"];
            ReleasedDate = (DateTime)valueObject["Released Data"];

            
        }



        public Album( string title, Artist artist, Track trackTitle, Track numberOfTrack, DateTime releasedDate )
        {
            _title = title;
            _artist = artist;
            _trackTitle = trackTitle;
            _numberOfTrack = numberOfTrack;
            _releasedDate = releasedDate;

        }
    }
}
