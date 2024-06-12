namespace MathGame.Model;

internal class Game
{
    public int Score { get; set; }
    public DateTime Date { get; set; }
    public GameType GameMode { get; set; }
    public string PlayerName { get; set; }

    internal Game(GameType gameMode, int score, string date, string playerName)
    {
        GameMode = gameMode;
        Score = score;
        Date = DateTime.Parse(date);
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