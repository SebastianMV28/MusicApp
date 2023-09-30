using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class MusicGenre
    {
        private int _id;
        private Artist _relatedArtist;
        private string _genreName, _subGenreName;
        private User _listener;
        
        public int Id { get { return _id; } set { _id = value; } }
        public Artist RelatedArtist {get => _relatedArtist; set=> _relatedArtist = value; }
        public string GenreName { get { return _genreName; } set { _genreName = value; } }
        public string SubGenreName { get { return _subGenreName; } set { _subGenreName = value; } }
        public User Listener { get { return _listener; } set { _listener= value; } }
    
        }
}