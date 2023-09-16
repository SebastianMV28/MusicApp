using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class Playlist
    {
        public int Id {  get; set; }
        public string PlayListName { get; set; }
        public string PlayListDescription { get; set;}

        public string RelatedArtist {  get; set; }

        public string RelatedAlbum { get; set;}
        public int NumberOfTracks { get; set;} = 0;

        public DateTime DateTime { get; set; }
    }
}
