using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace MusicApp
{
    public class User: UserEntity
    {
        
        private Playlist _playlist;
        private Artist _favoriteArtist;
        private Album _favoriteAlbum;
        private MusicGenre _favoriteMusicGenre;
        private UserType _type;
        
        public MusicGenre FavoriteMusicGender { get { return _favoriteMusicGenre; } set { _favoriteMusicGenre = value; } }
        public Playlist Playlist { get { return _playlist; } set { _playlist = value; } }
        public Artist FavoriteArtist { get { return _favoriteArtist; } set { _favoriteArtist= value; } }
        public Album FavoriteAlbum { get { return _favoriteAlbum; }  set { _favoriteAlbum= value; } }

        public UserType Type { get => _type; set => _type = value; }


        public User(JObject valueObject)
        {
            Id=  (string)valueObject["id"].ToObject<JObject>();
            Name= (string)valueObject["Name"].ToObject<JObject>();
            TelephoneNumber= (string)valueObject["Telephone"].ToObject<JObject>();
            Email= (string)valueObject["email"].ToObject<JObject>();
            Password = (string)valueObject["password"].ToObject<JObject>();
          
        }

        public User(string id,string name, string email, string password, string telephoneNumber, UserType type) : base(id,name, email, password, telephoneNumber)

        {
            _type = type;

        }

        public User(Artist favoriteArtist, Album favoriteAlbum, MusicGenre favoriteMusicGenre, UserType type) 
        {
             _type = type;
            _favoriteAlbum = favoriteAlbum;
            _favoriteArtist = favoriteArtist;
            _favoriteMusicGenre = favoriteMusicGenre;

        }

        public User(string email, string password) : base(email, password) 
        {
          
        }

        
    }
}
