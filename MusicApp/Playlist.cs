using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class Playlist
    {
        private int _id;
        private Artist _relatedArtist;
        private string _playListName, _playListDescription;
        private Track _track;
        private Album _album;

        public int Id { get { return _id; } set { _id = value; } }
        public string PlayListName { get { return _playListName; } set { _playListName = value; } }
        public string PlayListDescription { get { return _playListDescription; } set { _playListDescription = value; } }

        public Artist RelatedArtist { get { return _relatedArtist; } set { _relatedArtist = value; } }
        public Album Album { get { return _album; } set { _album = value; } }

        public Track Track { get => _track; set { _track = value; } }



        public Playlist(string playListName, string playListDescription)
        {
            _playListName = playListName;
            _playListDescription = playListDescription;

        }

        public Playlist(Track track, Artist relatedArtist, Album album) 
        {
            _track = track;
            _relatedArtist = relatedArtist;
            _album = album;
        }

    }
}
