using static System.Formats.Asn1.AsnWriter;

namespace MathGame.Model;

internal static class Helper
{
    internal static List<Game> games = new List<Game>
    {
        new Game(GameType.Addition, 10, "12-06-2024", "Player 1"),
        new Game(GameType.Subtraction, 7, "10-06-2024", "Player 2"),
        new Game(GameType.Multiplication, 5, "09-06-2024", "Player 3"),
        new Game(GameType.Division, 7, "11-06-2024", "Player 4"),
        new Game(GameType.Addition, 12, "12-06-2024", "Player 5")
    };

    internal static void SaveGame(Game game)
    {
        DateTime now = DateTime.UtcNow;
        Console.Write("Enter name to save score: ");
        game.PlayerName = Console.ReadLine();
        game.Date = DateTime.Parse(now.ToString("dd-MM-yyyy"));
        games.Add(game);
    }

    internal static void PrintHistory()
    {
        var gamesToPrint = games.Where(x => x.Score > 0)
            .OrderByDescending(x => x.Score)
            .ThenBy(x => x.Date);

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
