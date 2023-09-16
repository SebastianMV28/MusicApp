using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class MusicGenre
    {
        public int Id {  get; set; }
        public string GenreName { get; set; }
        public string SubGenreName { get; set; }
        public int NumberOfListeners {  get; set; }
        public string NumberOfArtists {  get; set; }
    }
}
