// Var declartion
string username;
var date = DateTime.UtcNow;

Console.WriteLine("Please type your name");
username = Console.ReadLine();

Menu(username, date);

static void Menu(string username, DateTime date)
{
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine($"Hello {username}, today is {date.DayOfWeek}.\n");
    Console.WriteLine(@$"Please press one of the following keys to play a game:
        A - Addition
        S - Subtraction
        M - Multiplication
        D - Division
        Q - Quit");
    Console.WriteLine("--------------------------------------------");
    var gameSelected = Console.ReadLine();

    switch (gameSelected.Trim().ToUpper())
    {
        case "A":
            Addition();
            break;
        case "S":
            Subtraction();
            break;
        case "M":
            Multiplication();
            break;
        case "D":
            Division();
            break;
        case "Q":
            Console.WriteLine("Goodbye");
            break;
        default:
            Console.WriteLine("Invalid selection");
            break;
    }
}
static void Addition()
{
    Console.WriteLine("Addition game selected...");
}

static void Subtraction()
{
    Console.WriteLine("Subtraction game selected...");
}

static void Multiplication()
{
    Console.WriteLine("Multiplication game selected...");
}

static void Division()
{
    Console.WriteLine("Division game selected...");
}

