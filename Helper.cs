using static System.Formats.Asn1.AsnWriter;

namespace MathGame.Model;

internal static class Helper
{
    internal static List<Game> games = new List<Game>
    {
        new Game(GameType.Addition, 0, "12-06-2024", "John Smith"),
        new Game(GameType.Addition, 29, "12-06-2024", "Khabib"),
        new Game(GameType.Addition, 14, "12-06-2024", "Islam"),
        new Game(GameType.Addition, 1, "12-06-2024", "B. Green"),
        new Game(GameType.Subtraction, 29, "10-06-2024", "Jon Jones"),
        new Game(GameType.Subtraction, 0, "10-06-2024", "Dummy"),
        new Game(GameType.Subtraction, 3, "10-06-2024", "A. Pereira"),
        new Game(GameType.Subtraction, 5, "10-06-2024", "S. Strickland"),
        new Game(GameType.Multiplication, 5, "09-06-2024", "Nhoj Thims"),
        new Game(GameType.Division, 7, "11-06-2024", "Dat Boi")
    };

    internal static void SaveGame(Game game)
    {
        DateTime now = DateTime.Now;
        Console.Write("\t\t\t\tEnter name to save score: ");
        game.PlayerName = Console.ReadLine();
        game.Date = now;
        games.Add(game);
    }

    internal static void PrintHighscores(List<Game> gamesToPrint)
    {
        Console.WriteLine($"\t\t\t\t##############################################");
        Console.WriteLine("\t\t\t\tRank\tScore\tPlayer name\tDate");
        int rank = 1;
        foreach (var game in gamesToPrint)
        {
            Console.WriteLine($"\t\t\t\t{rank}\t{game.Score}\t{game.PlayerName}\t{game.Date:dd-MM-yyyy}");
            rank++;
        }
        Console.WriteLine($"\t\t\t\t##############################################");

    }

    internal static void DisplayHighScores()
    {
        throw new NotImplementedException();
    }

    internal static string? ValidateAnswer(string? userAnswer)
    {
        while (string.IsNullOrEmpty(userAnswer) || !Int32.TryParse(userAnswer, out int result))
        {
            Console.Write("\t\t\t\tInvalid input. Please enter a number: ");
            userAnswer = Console.ReadLine();
        }
        return userAnswer;
    }
}
