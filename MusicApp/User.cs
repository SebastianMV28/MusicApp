using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    public class User: UserEntity
    {

        public UserEntity _name;
        public UserEntity _email;
        public UserEntity _password;
        public UserEntity _telephone;
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

        public User(string name, string email, string password, string telephoneNumber, UserType type) : base(name, email, password, telephoneNumber)

        {
            type = _type;

        }

        public User(Artist favoriteArtist, Album favoriteAlbum, MusicGenre favoriteMusicGenre) 
        {
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
