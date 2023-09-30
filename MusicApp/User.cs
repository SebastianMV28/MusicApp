using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class User
    {
        private int _id;
        private string _name, _email, _password, _telephoneNumber;
        private Playlist _playlist;
        private Artist _favoriteArtist;
        private Album _favoriteAlbum;
        private MusicGenre _favoriteMusicGenre;
        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name} set { _name = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public string TelephoneNumber { get { return _telephoneNumber; } set { _telephoneNumber = value; } }
        public MusicGenre FavoriteMusicGender { get { return _favoriteMusicGenre; } set { _favoriteMusicGenre = value; } }
        public Playlist Playlist { get { return _playlist; } set { _playlist = value; } }
        public Artist FavoriteArtist { get { return _favoriteArtist; } set { _favoriteArtist= value; } }
        public Album FavoriteAlbum { get { return _favoriteAlbum; }  set { _favoriteAlbum= value; } }
      

    }
}
