

var date = DateTime.UtcNow;
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
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math game. That's great you're working to improve yourself\n");
    Console.WriteLine($@"What game would you like to play today? Choose from below:
            A - Addition 
            S - Subtraction
            M - Multiplication
            D - Division
            Q - Quit Program");

    Console.WriteLine("------------------------------------------");

    var gamechoice = Console.ReadLine();

    switch (gamechoice.Trim().ToLower())
    {
        case "a":
            AdditionGame("You've selected Addition");
            break;
        case "s":
            SubtractionGame("You've selected Subtraction ");
            break;
        case "m":
            MultiplacationGame("You've selected Multiplication");
            break;
        case "d":
            DivisionGame("You've selected Division");
            break;
        case "q":
            Console.WriteLine("Goodbye");
            Environment.Exit(1);
            break;
        default:
            Console.WriteLine("Invalid Input");
            Environment.Exit(1);
            break;
    }
           

           
}
void AdditionGame(string message)
{
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
        
        if(int.Parse(result) == firstNum+secondNum)
        {
            Console.WriteLine("That is Correct");
            score++;
        }
        else 
        {
            Console.WriteLine("That is Incorrect");
        }

        if (i == 4) Console.WriteLine($"Your score is {score}");
    }
}
void SubtractionGame(string message)
{
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
        
        if(int.Parse(result) == firstNum - secondNum)
        {
            Console.WriteLine("That is Correct");
            score++;
        }
        else 
        {
            Console.WriteLine("That is Incorrect");
        }

        if (i == 4) Console.WriteLine($"Your score is {score}");
    }
}
void MultiplacationGame(string message)
{
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
        
        if(int.Parse(result) == firstNum * secondNum)
        {
            Console.WriteLine("That is Correct");
            score++;
        }
        else 
        {
            Console.WriteLine("That is Incorrect");
        }

        if (i == 4) Console.WriteLine($"Your score is {score}");
    }
} 
void DivisionGame(string message)
{
    GetDivsionNum();
    
}

int[] GetDivsionNum()
{
    var random = new Random();

    var firstNum = random.Next(0, 99);
    var secondNum = random.Next(0, 99);
    
     
    var result = new int [2];

    result[0] = firstNum;
    result[1] = secondNum;

    foreach (var number in result)
    {
        Console.WriteLine($"This is the first array number {number}");
    }
   Console.WriteLine(result);
    
    return result;
}
