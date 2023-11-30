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
        private string _title;
        private Artist _artist;
        private Track _trackTitle;
        private DateTime _releasedDate;
        private MusicGenre _musicGenre;
        public int Id { get { return _id; } set { _id = value; } }
        public Artist Artist { get { return _artist; } set { _artist = value; } }
        public string Title { get { return _title; } set { _title = value; } }
        public DateTime ReleasedDate { get { return _releasedDate; } set { _releasedDate = value; } }
        public Track TrackTitle { get { return _trackTitle; } set { _trackTitle = value; } }
        public MusicGenre MusicGenre { get { return _musicGenre; } set { _musicGenre = value; } }

        public Album(JObject valueObject)
        {
            var album = valueObject["Album"].ToObject<JObject>();
            var jObjectArtist = valueObject["Artist"].ToObject<JObject>();
            var jObjectTrack = valueObject["Track"].ToObject<JObject>();
            var JObjectMusicGenre = valueObject["MusicGenre"].ToObject<JObject>();
            var artistObject = new Artist(jObjectArtist);
            var trackObject = new Track(jObjectTrack);
            var musicGenreObject = new MusicGenre(JObjectMusicGenre);
            Id = (int)valueObject["Id"];
            Title = (string)valueObject["Title"];
            Artist = artistObject;
            TrackTitle = trackObject;
            ReleasedDate = (DateTime)valueObject["Released Data"];
            MusicGenre = musicGenreObject;
        }

        public Album(string title, Artist artist, DateTime releasedDate)
        {
            _title = title;
            _artist = artist;
            
            _releasedDate = releasedDate;

        }
        public Album(Track trackTitle)
        {
            _trackTitle=trackTitle;
        }
    }
}
