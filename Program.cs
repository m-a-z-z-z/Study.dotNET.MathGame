// Var declartion
using System.ComponentModel.Design;
using MathGame;

string? username = null;
DateTime date = DateTime.UtcNow;

while (username == null)
{
    Console.WriteLine("Please type your name: ");
    username = Console.ReadLine();
}

Menu();
void Menu()
{
    Console.WriteLine("##############################################");
    Console.WriteLine("#           Welcome to Math Game             #");
    Console.WriteLine("#           1. New game                      #");
    Console.WriteLine("#           2. Load game                     #");
    Console.WriteLine("#           3. View highscores               #");
    Console.WriteLine("#           4. Quit                          #");
    Console.WriteLine("##############################################");

    ConsoleKeyInfo keyInfo;
    int selectedOption = ;

    do
    {
        keyInfo = Console.ReadKey();

        switch (keyInfo.Key)
        {
            case ConsoleKey.UpArrow:
                selectedOption = Math.Max(selectedOption--, 1);
                break;
            case ConsoleKey.DownArrow:
                selectedOption = Math.Min(selectedOption++, 4);
                break;
            case ConsoleKey.Enter:
                switch (selectedOption)
                {
                    case 1:
                        CreateUser();
                        break;
                    case 2:
                        //SelectUser();
                        break;
                    case 3:
                        //ViewHighScores();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
                break;
        }

        Console.Clear();
        Console.WriteLine("##############################################");
        Console.WriteLine("#           Welcome to Math Game             #");
        Console.WriteLine("#           1. New game                      #");
        Console.WriteLine("#           2. Load game                     #");
        Console.WriteLine("#           3. View highscores               #");
        Console.WriteLine("#           4. Quit                          #");
        Console.WriteLine("##############################################");
    } while (keyInfo.Key != ConsoleKey.Enter);

    //var menuSelection = Console.ReadLine();


}


void CreateUser()
{
    User user = new User();
    Console.WriteLine("Enter username to track score: ");
    user.name = Console.ReadLine();
    GameSelect();
}

void GameSelect()
{
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine($"Hello {user.name}, today is {date.DayOfWeek}.\n");
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
void Addition()
{
    Console.WriteLine("Addition game selected...");

    var random = new Random();
    var firstNum = random.Next(1, 10);
    var secondNum = random.Next(1, 10);
    
    Console.WriteLine($"{firstNum} + {secondNum} = ?");
    var result = Console.ReadLine();

    while(result != ($"{firstNum + secondNum}"))
    {
        Console.WriteLine("Incorrect. Score reset. Try again.");
        user.score = 0;
        Console.WriteLine($"{firstNum} + {secondNum} = ?");
        result = Console.ReadLine();
    }
    user.score++;
    Console.WriteLine($"Correct! Score: {user.score}");
    GameSelect();
}

void Subtraction()
{
    Console.WriteLine("Subtraction game selected...");
}

void Multiplication()
{
    Console.WriteLine("Multiplication game selected...");
}

void Division()
{
    Console.WriteLine("Division game selected...");
}

