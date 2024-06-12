using static System.Formats.Asn1.AsnWriter;

namespace MathGame.Model;

internal static class Helper
{
    internal static List<Game> games = new List<Game>
    {
        new Game(GameType.Addition, 10, "12-06-2024", "John Smith"),
        new Game(GameType.Subtraction, 7, "10-06-2024", "Smohn Jith"),
        new Game(GameType.Multiplication, 5, "09-06-2024", "Nhoj Thims"),
        new Game(GameType.Division, 7, "11-06-2024", "Dat Boi"),
        new Game(GameType.Addition, 12, "12-06-2024", "Khabib")
    };

    internal static void SaveGame(Game game)
    {
        DateTime now = DateTime.Now;
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
        Console.WriteLine("\t\t\tDate\tPlayer name\tGame mode\tScore");
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

    internal static string? ValidateInput(string? userAnswer)
    {
        while (string.IsNullOrEmpty(userAnswer) || !Int32.TryParse(userAnswer, out int result))
        {
            Console.Write("Invalid input. Please enter a number: ");
            userAnswer = Console.ReadLine();
        }
        return userAnswer;
    }
}
