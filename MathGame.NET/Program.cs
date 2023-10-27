

var date = DateTime.UtcNow;
string name = GetName();

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
}
void SubtractionGame(string message)
{
    Console.WriteLine(message);
}
void MultiplacationGame(string message)
{
    Console.WriteLine(message);
} 
void DivisionGame(string message)
{
    Console.WriteLine(message);
}