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
        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name} set { _name = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Password { get { return _password; } set { _password = value; } }
        public MusicGenre FavoriteMusicGender { get { return FavoriteMusicGender; } set { FavoriteMusicGender = value; } }
        public string TelephoneNumber { get { return _telephoneNumber; } set { _telephoneNumber = value; } }
        public Playlist Playlist { get { return Playlist; } set { Playlist = value; } }
        public Artist FavoriteArtists { get { return FavoriteArtists; } set { FavoriteArtists = value; } }
        public Album FavoriteAlbums { get { return FavoriteAlbums; }  set { FavoriteAlbums = value; } }
        //public  FavoriteTracks { get; set; }

    }
}
