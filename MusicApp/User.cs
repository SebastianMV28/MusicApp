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
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FavoriteMusicGender { get; set; }
        public NumberFormatInfo TelephoneNumber { get; set; }
        public string Playlist { get; set; }
        public string FavoriteArtists { get; set; }
        public string FavoriteAlbums { get;  set; }
        public string FavoriteTracks { get; set; }

    }
}
