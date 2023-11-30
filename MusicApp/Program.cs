// See https://aka.ms/new-console-template for more information
using MusicApp;

Console.WriteLine("► Welcome to Music Wamp• ♪♫");

Artist artist = new Artist("Svartid");
Console.WriteLine(artist.Name);
MusicGenre musicGenre = new MusicGenre(MusicType.BlackMetal);

int genre = musicGenre.ValidateGenre();
Console.WriteLine($"your genre is {genre}");