using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    public class MusicGenre
    {
        private int _id;
        private Artist _relatedArtist;
        private string _genreName, _subGenreName;
        private User _listener;
        
        public int Id { get { return _id; } set { _id = value; } }
        public Artist RelatedArtist {get => _relatedArtist; set=> _relatedArtist = value; }
        public string GenreName { get { return _genreName; } set { _genreName = value; } }
        public string SubGenreName { get { return _subGenreName; } set { _subGenreName = value; } }
        public User Listener { get { return _listener; } set { _listener= value; } }

        public enum MusicType
        {
            Pop= 0,
            Rock=1,
            Folk=2,
            Blues=3,
            Country=4,
            Jazz=5,
            Soul=6,
            EDM=7,
            Fuck=8,
            Reggae=9,
            Disco=10,
            PunkRock=11,
            Classical=12,
            House= 13,
            Techno=14,
            IndieRock=15,
            Grunge=16,
            Ambient=17,
            Gospel=18,
            Grime= 19,
            Trap=20,
            HeavyMetal =21,
            SpeedMetal=22,
            ThrashMetal=23,
            DeathMetal=24,
            BlackMetal=25,
            Grindcore=26,
            Hardcore=27,
            HardcorePunk=28,
            Cumbia=29,
            Tropical=30,
            Salsa=31,
            Other=32
        }
        
        public MusicGenre (string genreName,  string subGenreName)
        {
            _genreName= genreName;
            _subGenreName= subGenreName;
        }


        public MusicGenre (Artist relatedArtist )
        {
            _relatedArtist = relatedArtist;
        }
    
        }
}