using MathGame.NET.Models;

namespace MathGame.NET;

internal class Helpers
{
    private static List<Game> games = new();
    internal static string GetName()
    {
        Console.WriteLine("Please Enter your name");
        var name = Console.ReadLine();
        return name;
    }
    internal static void GetGames()
    {
        Console.WriteLine("Games History");
        Console.WriteLine("-----------------------------\n");
        foreach (var game in games)
        {
        
            Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}pts");
        }
        Console.WriteLine("-------------------------\n");
        Console.WriteLine("Press any key to return to Main Menu");
        Console.ReadLine();
    
    }
    internal static int[] GetDivsionNum()
    {
        var random = new Random();
        var firstNum = random.Next(1, 99);
        var secondNum = random.Next(1, 99);

        var result = new int [2];

        while (firstNum % secondNum != 0)
        {
            firstNum = random.Next(1, 99);
            secondNum = random.Next(1, 99);
        }

        result[0] = firstNum;
        result[1] = secondNum;
        return result;
    }

    internal static void AddtoHistory(int gameScore, string gameType)
    {
        games.Add(new Game
        {
            Score = gameScore,
            Type = gameType,
            Date = DateTime.Now 
        });
    }
}