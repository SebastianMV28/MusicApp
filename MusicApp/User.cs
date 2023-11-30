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
        public UserEntity _id;
        public UserEntity _name;
        public UserEntity _email;
        public UserEntity _password;
        public UserEntity _telephone;
        private Playlist _playlist;
        private Artist _favoriteArtist;
        private Album _favoriteAlbum;
        private MusicGenre _favoriteMusicGenre;
        private UserType _type;
        public UserEntity Id { get=> _id  ; set=> _id= value; }
        public UserEntity Name { get=> _name ; set=> _name= value; }
        public UserEntity Email { get => _email; set=> _email= value; }
        public UserEntity Telephone { get=> _telephone; set=> _telephone= value; }
        public MusicGenre FavoriteMusicGender { get { return _favoriteMusicGenre; } set { _favoriteMusicGenre = value; } }
        public Playlist Playlist { get { return _playlist; } set { _playlist = value; } }
        public Artist FavoriteArtist { get { return _favoriteArtist; } set { _favoriteArtist= value; } }
        public Album FavoriteAlbum { get { return _favoriteAlbum; }  set { _favoriteAlbum= value; } }

        public UserType Type { get => _type; set => _type = value; }

        public User(JObject valueObject)
        {
            var jObjectId=  (int)valueObject["id"].ToObject<JObject>();
            var jObjectUserName= valueObject["Name"].ToObject<JObject>();
            var jObjectUserTelephone= valueObject["Telephone"].ToObject<JObject>();
            var jObjectEmail= valueObject["email"].ToObject<JObject>();
            var jObjectUserPassword = valueObject["password"].ToObject<JObject>();
            var idObject = new UserEntity(jObjectId);
            var nameObject= new UserEntity(jObjectUserName);
            var emailObject= new UserEntity(jObjectEmail);
            Id = idObject;
            Name = nameObject;

            Email = emailObject;
            Password = (string)valueObject["password"];
            
        }

        public User(int id,string name, string email, string password, string telephoneNumber, UserType type) : base(id,name, email, password, telephoneNumber)

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

        public User(UserEntity email, UserEntity password)
        {
            _email = email;
            _password = password;
        }

        
    }
}
