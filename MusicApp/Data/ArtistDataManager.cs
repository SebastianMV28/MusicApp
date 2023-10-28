using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Data
{
    public static class ArtistDataManager
    {
        public static void SaveArtist(Artist artist)=> Console.WriteLine(artist.ArtistName);
    }
}
