using static System.Formats.Asn1.AsnWriter;

namespace MathGame.Model;

internal static class Helper
{
    internal static List<Game> games = new List<Game>();

    internal static void SaveGame(Game game)
    {
        games.Add(game);
    }

    internal static void PrintHistory()
    {
        foreach (var game in games)
        {
            Console.WriteLine($"{game.Date} --- {game.PlayerName} --- Game mode: {game.GameMode} --- Score: {game.Score}");
        }
    }

    internal static void DisplayHighScores()
    {
        throw new NotImplementedException();
    }
}
