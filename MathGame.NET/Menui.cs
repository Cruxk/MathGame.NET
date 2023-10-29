namespace MathGame.NET;

internal class Menui
{
    private MathOperations engine = new();
    internal void ShowMenu(string name, DateTime date)
    {   
        Console.Clear();
        var isGameOn = true;

        do
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(
                $"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math game. That's great you're working to improve yourself\n");
            Console.WriteLine($@"What game would you like to play today? Choose from below:
            V - Previous Scores
            A - Addition 
            S - Subtraction
            M - Multiplication
            D - Division
            Q - Quit Program");

            Console.WriteLine("------------------------------------------");
            var gamechoice = Console.ReadLine();

            switch (gamechoice.Trim().ToLower())
            {
                case "v":
                    Helpers.GetGames();
                    break;
                case "a":
                    engine.AdditionGame("Addition");
                    break;
                case "s":
                    engine.SubtractionGame("Subtraction ");
                    break;
                case "m":
                    engine.MultiplacationGame("Multiplication");
                    break;
                case "d":
                   engine.DivisionGame("Division");
                    break;
                case "q":
                    Console.WriteLine("Goodbye");
                    isGameOn = false;
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

        } while (isGameOn);
    }
}