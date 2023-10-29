namespace MathGame.NET;

internal class MathOperations
{
    internal void AdditionGame(string message)
    { 
        
        Console.Clear();
        Console.WriteLine(message);

        var random = new Random();
        int firstNum;
        int secondNum;
        var score = 0;

        for (int i = 0; i < 5; i++)
        {
            firstNum = random.Next(1, 9);
            secondNum = random.Next(1, 9);

            Console.WriteLine($"{firstNum} + {secondNum}");

            var result = Console.ReadLine();

            if (int.Parse(result) == firstNum + secondNum)
            {
                Console.WriteLine("That is Correct. Press another key to continue.");
                Console.ReadLine();
                score++;
                Console.Clear();
            }
            else
            {
                Console.WriteLine("That is Incorrect. Press another key to continue.");
                Console.ReadLine();
                Console.Clear();
            }

            if (i == 4)
            {
                Console.WriteLine($"Your score is {score}. Press any key to go back to the menu");
                {
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
        Helpers.AddtoHistory(score, "Addition");
    }

    internal void SubtractionGame(string message)
    {
        Console.Clear();
        Console.WriteLine(message);

        var random = new Random();
        int firstNum;
        int secondNum;
        var score = 0;

        for (int i = 0; i < 5; i++)
        {
            firstNum = random.Next(1, 9);
            secondNum = random.Next(1, 9);

            Console.WriteLine($"{firstNum} - {secondNum}");

            var result = Console.ReadLine();

            if (int.Parse(result) == firstNum - secondNum)
            {
                Console.WriteLine("That is Correct. Press another key to continue.");
                Console.ReadLine();
                score++;
                Console.Clear();
            }
            else
            {
                Console.WriteLine("That is Incorrect. Press another key to continue.");
                Console.ReadLine();
                Console.Clear();
            }

            if (i == 4) Console.WriteLine($"Your score is {score}. Press any key to continue to the main menu.");
            {
                Console.ReadLine();
                Console.Clear();
            }
        }
        Helpers.AddtoHistory(score, "Subtraction");
    }

  internal void MultiplacationGame(string message)
    {
        Console.Clear();
        Console.WriteLine(message);

        var random = new Random();
        int firstNum;
        int secondNum;
        var score = 0;

        for (int i = 0; i < 5; i++)
        {
            firstNum = random.Next(1, 9);
            secondNum = random.Next(1, 9);

            Console.WriteLine($"{firstNum} * {secondNum}");

            var result = Console.ReadLine();

            if (int.Parse(result) == firstNum * secondNum)
            {
                Console.WriteLine("That is Correct. Press another key to continue");
                Console.ReadLine();
                score++;
                Console.Clear();
            }
            else
            {
                Console.WriteLine("That is Incorrect. Press another key to continue");
                Console.ReadLine();
                Console.Clear();
            }

            if (i == 4) Console.WriteLine($"Your score is {score}. Press any key to continue to the main menu.");
            {
                Console.ReadLine();
                Console.Clear();
            }
        }
        Helpers.AddtoHistory(score, "Multiplication");
    }

    internal void DivisionGame(string message)
    {
        Console.Clear();
        Console.WriteLine(message);
        var score = 0;
        for (int i = 0; i < 5; i++)
        {
            var divisableNum = Helpers.GetDivsionNum();
            var firstNum = divisableNum[0];
            var secondNum = divisableNum[1];
            

            Console.WriteLine($"{firstNum} / {secondNum}");

            var result = Console.ReadLine();

            if (int.Parse(result) == firstNum / secondNum)
            {
                Console.WriteLine("That is Correct. Press another key to continue");
                Console.ReadLine();
                score++;
                Console.Clear();
            }
            else
            {
                Console.WriteLine("That is incorrect. Press another key to continue");
                Console.ReadLine();
                Console.Clear();
            }

            if (i == 4) Console.WriteLine($"You're score is {score}. Press any key to continue to the main menu.");
            {
                Console.ReadLine();
                Console.Clear(); 
            }
        }
        Helpers.AddtoHistory(score, "Division");
    }
}