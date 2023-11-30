using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    public class Artist : UserEntity
    {
        //private int _id;
        private string _country;
        private MusicGenre _musicGenre;
        private Album _album;
        private UserType _type;
        //public int Id { get { return _id; } set { _id = value; } }
        //public string ArtistName { get { return _artistName; } set { _artistName = value; } }
        public MusicGenre MusicGenre { get { return _musicGenre; } set { _musicGenre = value; } }
        public string Country { get { return _country; } set { _country = value; } }
        public Album Album { get => _album; set => _album = value; }
        public UserType Type { get => _type; set => _type = value; }

        public Artist(JObject valueObject)
        {
            var artist = valueObject["Artist"].ToObject<JObject>();
            var jObjectAlbum = valueObject["Album"].ToObject<JObject>();
            var albumObject = new Album(jObjectAlbum);
            var jObjectMusicGenre = valueObject["MusicGenre"].ToObject<JObject>();
            var musicGenreObject= new MusicGenre(jObjectMusicGenre);
            Id = (int)valueObject["id"];
            Name = (string)valueObject["Name"];
            Country = (string)valueObject["Country"];
            MusicGenre = musicGenreObject;
            Album = albumObject;
        }

        public Artist(string name):base(name)
        {
            
        }
        public Artist(MusicGenre musicGenre, string country)
        {
            
            _musicGenre = musicGenre;
            _country = country;
        }

        public Artist(int id, string name, string email, string password, string telephoneNumber, UserType type) : base(id,name, email, password, telephoneNumber)
        {
            _type = type;
        }
    }
}
