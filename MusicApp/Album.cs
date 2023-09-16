using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class Album
    {
        public string BandName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleasedDate { get; set; }
        public int NumberOfSongs { get; set; }
        public string SongTitle {  get; set; }

        public Album() { }
    }
}
