using static System.Formats.Asn1.AsnWriter;

namespace MathGame.Model;

internal static class Helper
{
    internal static List<Game> games = new List<Game>();

    internal static void SaveGame(Game game)
    {
        DateTime now = DateTime.UtcNow;
        Console.Write("Enter name to save score: ");
        game.PlayerName = Console.ReadLine();
        game.Date = now.ToString("dd-MM-yyyy");
        games.Add(game);
    }

    internal static void PrintHistory()
    {
        Console.WriteLine($"\t\t\t\t##############################################");
        Console.WriteLine("\t\t\t\tDate --- Player name --- Game mode --- Score");
        foreach (var game in games)
        {
            Console.WriteLine($"\t\t\t{game.Date} --- {game.PlayerName} --- {game.GameMode} --- {game.Score}");
        }
        Console.WriteLine($"\t\t\t\t##############################################");

    }

    internal static void DisplayHighScores()
    {
        throw new NotImplementedException();
    }
}
