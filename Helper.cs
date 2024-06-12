using static System.Formats.Asn1.AsnWriter;

namespace MathGame.Model;

internal static class Helper
{
    internal static List<Game> games = new List<Game>
    {
        new Game(GameType.Addition, 18, "12-06-2024", "A. Pantoja"),
        new Game(GameType.Addition, 18, "11-06-2024", "B. Royval"),
        new Game(GameType.Addition, 17, "10-06-2024", "B. Moreno"),
        new Game(GameType.Addition, 16, "09-06-2024", "A. Albazi"),
        new Game(GameType.Addition, 15, "12-06-2024", "K. France"),
        new Game(GameType.Addition, 13, "12-06-2024", "A. Perez"),
        new Game(GameType.Addition, 11, "12-06-2024", "M. Mokaev"),
        new Game(GameType.Addition, 10, "12-06-2024", "M. Kape"),
        new Game(GameType.Addition, 9, "12-06-2024", "M. Kape"),
        new Game(GameType.Addition, 5, "12-06-2024", "M. Nicolau"),
        new Game(GameType.Addition, 6, "12-06-2024", "S. Erceg"),
        new Game(GameType.Addition, 0, "12-06-2024", "T. Elliot"),

        new Game(GameType.Subtraction, 29, "12-06-2024", "S O\'Malley"),
        new Game(GameType.Subtraction, 28, "11-06-2024", "M. Dvalishvili"),
        new Game(GameType.Subtraction, 28, "10-06-2024", "C. Sandhagen"),
        new Game(GameType.Subtraction, 20, "10-06-2024", "M. Vera"),
        new Game(GameType.Subtraction, 14, "09-06-2024", "H. Cejudo"),
        new Game(GameType.Subtraction, 14, "09-06-2024", "D. Figueiredo"),
        new Game(GameType.Subtraction, 13, "08-06-2024", "S. Yadong"),
        new Game(GameType.Subtraction, 12, "08-06-2024", "J. Aldo"),
        new Game(GameType.Subtraction, 10, "07-06-2024", "R. Font"),
        new Game(GameType.Subtraction, 5, "06-06-2024", "U. Nurmagonedov"),
        new Game(GameType.Subtraction, 0, "05-06-2024", "K. Phillips"),

        new Game(GameType.Multiplication, 29, "12-06-2024", "I. Topuria"),
        new Game(GameType.Multiplication, 28, "11-06-2024", "A. Volk"),
        new Game(GameType.Multiplication, 28, "10-06-2024", "M. Holloway"),
        new Game(GameType.Multiplication, 20, "10-06-2024", "B. Ortega"),
        new Game(GameType.Multiplication, 14, "09-06-2024", "Y. Rodriguez"),
        new Game(GameType.Multiplication, 14, "09-06-2024", "M. Evloev"),
        new Game(GameType.Multiplication, 13, "08-06-2024", "A. Allen"),
        new Game(GameType.Multiplication, 12, "08-06-2024", "A. Sterling"),
        new Game(GameType.Multiplication, 10, "07-06-2024", "J. Emmett"),
        new Game(GameType.Multiplication, 5, "06-06-2024", "C. Kattar"),
        new Game(GameType.Multiplication, 0, "05-06-2024", "G. Chikadze"),

        new Game(GameType.Division, 29, "12-06-2024", "I. Makhachev"),
        new Game(GameType.Division, 28, "11-06-2024", "C. Oliveira"),
        new Game(GameType.Division, 28, "10-06-2024", "J. Gaethje"),
        new Game(GameType.Division, 20, "10-06-2024", "D. Poirier"),
        new Game(GameType.Division, 14, "09-06-2024", "M. Gamrot"),
        new Game(GameType.Division, 14, "09-06-2024", "M. Chander"),
        new Game(GameType.Division, 13, "08-06-2024", "B. Dariush"),
        new Game(GameType.Division, 12, "08-06-2024", "R. Fiziev"),
        new Game(GameType.Division, 10, "07-06-2024", "M. Holloway"),
        new Game(GameType.Division, 5, "06-06-2024", "R. Moicano"),
        new Game(GameType.Division, 0, "05-06-2024", "D. Hooker")
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
        Console.WriteLine("\t\t\t\tDate Set\tRank\tScore\tPlayer name");
        int rank = 1;
        foreach (var game in gamesToPrint)
        {
            Console.WriteLine($"\t\t\t\t{game.Date:dd-MM-yyyy}\t{rank}\t{game.Score}\t{game.PlayerName}");
            rank++;
        }
        Console.WriteLine($"\t\t\t\t##############################################");

    }

    internal static void DisplayHighScores()
    {
        throw new NotImplementedException();
    }

    internal static string? ValidateNumber(string? userAnswer)
    {
        while (string.IsNullOrEmpty(userAnswer) || !Int32.TryParse(userAnswer, out int result))
        {
            Console.Write("\t\t\t\tInvalid input. Please enter a number: ");
            userAnswer = Console.ReadLine();
        }
        return userAnswer;
    }

    internal static string? ValidateString(string? input)
    {
        while (string.IsNullOrEmpty(input) || !IsNameValid(input))
        {
            Console.Write("\t\t\t\tInvalid input. Please enter alphabetic characters only: ");
            input = Console.ReadLine();
        }
        return input;
    }

    private static bool IsNameValid(string input)
    {
        // Check if the name contains only alphabetic characters, spaces, and full stops
        foreach (char c in input)
        {
            if (!char.IsLetter(c) && c != ' ' && c != '.')
            {
                return false;
            }
        }
        return true;
    }
}
