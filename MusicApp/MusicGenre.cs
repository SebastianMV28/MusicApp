using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class MusicGenre
    {
        private int _id, _numberOfListeners, _numberOfArtists;
        private string _genreName, _subGenreName;
        public int Id { get { return _id; } set { _id = value; } }
        public string GenreName { get { return _genreName; } set { _genreName = value; } }
        public string SubGenreName { get { return _subGenreName; } set { _subGenreName = value; } }
        public int NumberOfListeners { get { return _numberOfListeners; } set { _numberOfListeners = value; } }
        public int NumberOfArtists { get { return _numberOfArtists; } set { _numberOfArtists = value; } }
        }
}