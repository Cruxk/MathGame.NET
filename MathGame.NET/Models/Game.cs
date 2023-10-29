namespace MathGame.NET.Models;

internal class Game
{
    private int _score;
    public int Score { get; set; }
    public GameType Type { get; set; }
    public DateTime Date { get; set; }
    
    internal enum GameType
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }
}