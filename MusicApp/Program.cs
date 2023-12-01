// See https://aka.ms/new-console-template for more information
using MusicApp;
using Newtonsoft.Json.Linq;



 static void MainMenu()
{
    Console.WriteLine("\"► Welcome to Music Wamp• ♪♫\"");  
    
    
    Console.WriteLine("Select one of the options bellow");
    Console.WriteLine("----------------------------------");
    Console.WriteLine("1- Register ");
    Console.WriteLine("2- Sign Up with your account");
}

static void MenuRegister(string[] args)
{
    string opt = Console.ReadLine();
    switch (opt)
    {
        case "1":
            Console.WriteLine("Register User");
            Console.WriteLine("1");
            
            
            break;
        case "2":
            Console.WriteLine("Sign Up");
    }
}

Artist artist = new Artist("Svartid");
User user = new User("svar@gmail.com", "12345");
Album album = new Album("Painkiller",new Artist("JudasPriest"), new DateTime(1980,04,29));
MusicGenre musicGenre = new MusicGenre(MusicType.BlackMetal);

int genre = musicGenre.ValidateGenre();
Console.WriteLine(artist.Name);
Console.WriteLine(user.SingAccess());

Console.WriteLine(album.Title, album.Artist, album.ReleasedDate);
Console.WriteLine($"your genre is {genre}");