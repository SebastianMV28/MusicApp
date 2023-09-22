using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class Artist
    {
        private int _id;
        private string _artistName, _country, _subGenre;
        public int Id { get { return _id; } set { _id = value; }}
        public string ArtistName { get { return _artistName; } set { _artistName = value; } }

        public MusicGenre MusicGenre { get { return MusicGenre; } set { MusicGenre = value; } }

        public string Country { get { return _country; } set { _country = value; } }
        public string subGenre { get { return _subGenre; } set { _subGenre = value; } }
    }
}
