using Newtonsoft.Json.Linq;
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
        private MusicType _genre;
        public int Id { get { return _id; } set { _id = value; } }

        public MusicType Genre { get => _genre; set => _genre = value; }

        public MusicGenre(JObject valueObject)
        {
            //var musicGenre = valueObject["MusicGenre"].ToObject<JObject>();
            Id = (int)valueObject["id"];
            Genre = (MusicType)(int)valueObject["genre"];

        }

        public MusicGenre(MusicType genre)
        {
            _genre = genre;
            

        }

        public int ValidateGenre()
        {
            
            if (_genre == null)
               
                
            {
                
                Console.WriteLine($"{_genre} is not a valid Genre, please insert a new one");
            }
            else
            {
                Console.WriteLine($"The genre that you've select is {_genre}");
            }
            return 0;
        }
    }

    
    public enum MusicType
    {
        Pop = 0,
        Rock = 1,
        Folk = 2,
        Blues = 3,
        Country = 4,
        Jazz = 5,
        Soul = 6,
        EDM = 7,
        Fuck = 8,
        Reggae = 9,
        Disco = 10,
        PunkRock = 11,
        Classical = 12,
        House = 13,
        Techno = 14,
        IndieRock = 15,
        Grunge = 16,
        Ambient = 17,
        Gospel = 18,
        Grime = 19,
        Trap = 20,
        HeavyMetal = 21,
        SpeedMetal = 22,
        ThrashMetal = 23,
        DeathMetal = 24,
        BlackMetal = 25,
        Grindcore = 26,
        Hardcore = 27,
        HardcorePunk = 28,
        Cumbia = 29,
        Tropical = 30,
        Salsa = 31,
        Other = 32
    }
}