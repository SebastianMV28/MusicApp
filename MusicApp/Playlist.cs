using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class Playlist
    {
        private int _id, _numberOfTracks;

        private string _playListName, _playListDescription;

        public int Id { get { return _id; } set { _id = value; } }
        public string PlayListName { get { return _playListName; } set { _playListName = value; } }
        public string PlayListDescription { get { return _playListDescription; } set { _playListDescription = value; } }

        public Artist RelatedArtist { get { return RelatedArtist; } set { RelatedArtist = value; } }

        public Album RelatedAlbum { get { return RelatedAlbum; } set { RelatedAlbum = value; } }
        public int NumberOfTracks { get { return _numberOfTracks; } set { _numberOfTracks = value; } }

    }
}
