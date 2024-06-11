namespace MathGame.Model;

internal class Game
{
    public int Score { get; set; }
    public DateTime Date { get; set; }
    public GameType GameMode { get; set; }
    public string PlayerName { get; set; }

    internal Game(GameType gameMode, int score, DateTime date, String playerName)
    {
        GameMode = gameMode;
        Score = score;
        Date = date;
        PlayerName = playerName;
    }

    internal Game(GameType gameMode) { GameMode = gameMode; }
}

internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division
}