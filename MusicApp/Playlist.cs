using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    public class Playlist
    {
        private int _id;
        private Artist _relatedArtist;
        private string _playListName;
        private Track _track;
        private Album _album;

        public int Id { get { return _id; } set { _id = value; } }
        public string PlayListName { get { return _playListName; } set { _playListName = value; } }
        public Artist RelatedArtist { get { return _relatedArtist; } set { _relatedArtist = value; } }
        public Album Album { get { return _album; } set { _album = value; } }
        public Track Track { get => _track; set { _track = value; } }

        public Playlist(JObject valueObject)
        {
            //var playlist = valueObject["Playlist"].ToObject<JObject>();
            var jObjectArtist=valueObject["Artist"].ToObject<JObject>();
            var jObjectAlbum = valueObject["Album"].ToObject<JObject>();
            var jObjectTrack = valueObject["Track"].ToObject<JObject>();
            var trackObject = new Track(jObjectTrack);
            var artistObject = new Artist(jObjectArtist);
            var albumObject = new Album(jObjectAlbum);
            Id= (int)valueObject["id"];
            PlayListName= (string)valueObject["PlayListName"];
            Track = trackObject;
            RelatedArtist= artistObject;
            Album = albumObject;

        }

        public Playlist(string playListName)
        {
            _playListName = playListName;
        }

        public Playlist(Track track, Artist relatedArtist, Album album)
        {
            _track = track;
            _relatedArtist = relatedArtist;
            _album = album;
        }

    }
}
