using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class Artist
    {
        public int Id { get; set; }
       public string ArtistName { get; set; }
       public string ArtistAlbums {  get; set; }

        public string TrackTitle {  get; set; }

        public string MusicGenre { get; set; }

        public string Country { get; set; }
        public string subGenre { get; set; }

    public Artist() { }
    }
}
