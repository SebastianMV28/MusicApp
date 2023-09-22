using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class Album
    {
        private string  _title, _description, _songTitle;
        private int _numberOfSongs;
        public Artist Artist{ get { return Artist; } set { Artist = value; } }
        public string Title { get { return _title; } set { _title = value; } }
        public string Description { get {return _description; } set { _description = value; } }
        public DateTime ReleasedDate { get { return ReleasedDate; } set { ReleasedDate= value;} }
        public int NumberOfSongs { get { return _numberOfSongs; } set { _numberOfSongs = value; } }
        public string SongTitle { get { return _songTitle; } set { _songTitle = value; } }
    }
}
