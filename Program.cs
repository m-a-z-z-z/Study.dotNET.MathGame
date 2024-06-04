// Var declartion
using System.ComponentModel.Design;
using MathGame;

string? username = null;
DateTime date = DateTime.UtcNow;
User user = new User();

NavigateMenu();
void NavigateMenu()
{
    ConsoleKeyInfo key;
    int selectedOption = 1;
    bool isSelected = false;
    DisplayMenu(1);

    while (!isSelected)
    {
        key = Console.ReadKey(true);

        switch(key.Key)
        {
            case ConsoleKey.DownArrow:
                selectedOption++;
                Console.Clear();
                if (selectedOption > 4)
                {
                    selectedOption = 1;
                    DisplayMenu(selectedOption);   // will cause menu to wrap back around to first menu item
                }
                else
                    DisplayMenu(selectedOption);
                break;

            case ConsoleKey.UpArrow:
                selectedOption--;
                Console.Clear();
                if (selectedOption < 1)
                {
                    selectedOption = 4;
                    DisplayMenu(selectedOption);   // will cause menu to wrap back around to last menu item
                }
                else
                    DisplayMenu(selectedOption);
                break;

            case ConsoleKey.Enter:
                isSelected = true;
                break;
        }
    }
    DisplayMenu(selectedOption);

}

void DisplayMenu(int selection)
{

    switch (selection)
    {
        case 1:
            Console.WriteLine("\t\t##############################################");
            Console.WriteLine("\t\t#           Welcome to Math Game             #");
            Console.WriteLine("\t\t#                                            #");
            Console.WriteLine("\t\t#                 \u001b[32mNew game\u001b[0m                   #");
            Console.WriteLine("\t\t#                 Load game                  #");
            Console.WriteLine("\t\t#              View highscores               #");
            Console.WriteLine("\t\t#                   Quit                     #");
            Console.WriteLine("\t\t#                                            #");
            Console.WriteLine("\t\t#   Use arrows keys to navigate menu items.  #");
            Console.WriteLine("\t\t#          Use enter key to select.          #");
            Console.WriteLine("\t\t##############################################");
            break;
        case 2:
            Console.WriteLine("\t\t##############################################");
            Console.WriteLine("\t\t#           Welcome to Math Game             #");
            Console.WriteLine("\t\t#                                            #");
            Console.WriteLine("\t\t#                 New game                   #");
            Console.WriteLine("\t\t#                 \u001b[32mLoad game\u001b[0m                  #");
            Console.WriteLine("\t\t#              View highscores               #");
            Console.WriteLine("\t\t#                   Quit                     #");
            Console.WriteLine("\t\t#                                            #");
            Console.WriteLine("\t\t#   Use arrows keys to navigate menu items.  #");
            Console.WriteLine("\t\t#          Use enter key to select.          #");
            Console.WriteLine("\t\t##############################################");
            break;
        case 3:
            Console.WriteLine("\t\t##############################################");
            Console.WriteLine("\t\t#           Welcome to Math Game             #");
            Console.WriteLine("\t\t#                                            #");
            Console.WriteLine("\t\t#                 New game                   #");
            Console.WriteLine("\t\t#                 Load game                  #");
            Console.WriteLine("\t\t#              \u001b[32mView highscores\u001b[0m               #");
            Console.WriteLine("\t\t#                   Quit                     #");
            Console.WriteLine("\t\t#                                            #");
            Console.WriteLine("\t\t#   Use arrows keys to navigate menu items.  #");
            Console.WriteLine("\t\t#          Use enter key to select.          #");
            Console.WriteLine("\t\t##############################################");
            break;
        case 4:
            Console.WriteLine("\t\t##############################################");
            Console.WriteLine("\t\t#           Welcome to Math Game             #");
            Console.WriteLine("\t\t#                                            #");
            Console.WriteLine("\t\t#                 New game                   #");
            Console.WriteLine("\t\t#                 Load game                  #");
            Console.WriteLine("\t\t#              View highscores               #");
            Console.WriteLine("\t\t#                   \u001b[32mQuit\u001b[0m                     #");
            Console.WriteLine("\t\t#                                            #");
            Console.WriteLine("\t\t#   Use arrows keys to navigate menu items.  #");
            Console.WriteLine("\t\t#          Use enter key to select.          #");
            Console.WriteLine("\t\t##############################################");
            break;
        default:
            Console.WriteLine("\t\t##############################################");
            Console.WriteLine("\t\t#           Welcome to Math Game             #");
            Console.WriteLine("\t\t#                                            #");
            Console.WriteLine("\t\t#                 \u001b[32mNew game\u001b[0m                   #");
            Console.WriteLine("\t\t#                 Load game                  #");
            Console.WriteLine("\t\t#              View highscores               #");
            Console.WriteLine("\t\t#                   Quit                     #");
            Console.WriteLine("\t\t#                                            #");
            Console.WriteLine("\t\t#   Use arrows keys to navigate menu items.  #");
            Console.WriteLine("\t\t##############################################");
            break;
    }
}

void CreateUser()
{
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

