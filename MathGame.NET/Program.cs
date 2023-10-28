var date = DateTime.UtcNow;
var games = new List<string>();
string name = GetName();

Menu(name);

string GetName()
{
    Console.WriteLine("Please Enter your name");
    var name = Console.ReadLine();
    return name;
}

void Menu(string name)
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
                GetGames();
                break;
            case "a":
                AdditionGame("Addition");
                break;
            case "s":
                SubtractionGame("Subtraction ");
                break;
            case "m":
                MultiplacationGame("Multiplication");
                break;
            case "d":
                DivisionGame("Division");
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

void GetGames()
{
    Console.WriteLine("Games History");
    Console.WriteLine("-----------------------------\n");
    foreach (var game in games)
    {
        
        Console.WriteLine(game);
    }
    Console.WriteLine("-------------------------\n");
    Console.WriteLine("Press any key to return to Main Menu");
    Console.ReadLine();
    
}
void AdditionGame(string message)
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
    AddtoHistory(score, "Addition");
}

void SubtractionGame(string message)
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
    AddtoHistory(score, "Subtraction");
}

void MultiplacationGame(string message)
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
    AddtoHistory(score, "Multiplication");
}

void DivisionGame(string message)
{
    Console.Clear();
    Console.WriteLine(message);
    var score = 0;
    for (int i = 0; i < 5; i++)
    {
        var divisableNum = GetDivsionNum();
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
    AddtoHistory(score, "Division");
}

int[] GetDivsionNum()
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

void AddtoHistory(int gameScore, string gameType)
{
    games.Add($"{DateTime.Now} - {gameType}: {gameScore}");
}