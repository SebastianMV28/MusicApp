// See https://aka.ms/new-console-template for more information
using MusicApp;
using Newtonsoft.Json.Linq;

Console.WriteLine("► Welcome to Music Wamp• ♪♫");

Artist artist = new Artist("Svartid");
User user = new User("svar@gmail.com", "12345");
Album album = new Album("Painkiller",new Artist("JudasPriest"), new DateTime(1980,04,29));
MusicGenre musicGenre = new MusicGenre(MusicType.BlackMetal);

int genre = musicGenre.ValidateGenre();
Console.WriteLine(artist.Name);
Console.WriteLine(user.SingAccess());

Console.WriteLine(album.Title, album.Artist, album.ReleasedDate);
Console.WriteLine($"your genre is {genre}");