// Var declartion
using System.ComponentModel.Design;
using MathGame;

string? username = null;
DateTime date = DateTime.UtcNow;
User user = new User();

Menu();
void Menu()
{
    Console.CursorVisible = false;
    ConsoleKeyInfo key;
    int selectedOption = 1;
    bool isSelected = false;
    (int left, int top) = Console.GetCursorPosition();  // cursor position coordinates look for column num (left) and row num (top). GetCursorPosition will get the current col and row and put it in left and top int variables. 
    string color = "\u001b[32m";    // green in UTF


    while (!isSelected)
    {
        Console.SetCursorPosition(left, top);   // Updates the cursor position to the location of the selected menu item.

        // Highlight selected menu item
        // (selectedOption == 1 ? color : "") 
        // ? = do this if condition is true
        // : = else if condition is false
        // if selectedOption is equal to 1, insert color string, else insert empty string

        Console.WriteLine("\t\t##############################################");
        Console.WriteLine("\t\t#           Welcome to Math Game             #");
        Console.WriteLine("\t\t#                                            #");
        Console.WriteLine($"\t\t#{(selectedOption == 1 ? color : "")}                 New game\u001b[0m                   #");
        Console.WriteLine($"\t\t#{(selectedOption == 2 ? color : "")}                 Load game\u001b[0m                  #");
        Console.WriteLine($"\t\t#{(selectedOption == 3 ? color : "")}              View highscores\u001b[0m               #");
        Console.WriteLine($"\t\t#{(selectedOption == 4 ? color : "")}                   Quit\u001b[0m                     #");
        Console.WriteLine("\t\t#                                            #");
        Console.WriteLine("\t\t#   Use arrows keys to navigate menu items.  #");
        Console.WriteLine("\t\t#          Use enter key to select.          #");
        Console.WriteLine("\t\t##############################################");

        key = Console.ReadKey(true);

        switch(key.Key)
        {
            case ConsoleKey.DownArrow:
                // if option is greater than for, ?(then) make option 1. :(else) increment option by 1
                selectedOption = (selectedOption == 4 ? 1 : selectedOption + 1);
                break;

            case ConsoleKey.UpArrow:
                selectedOption = (selectedOption == 1 ? 4 : selectedOption - 1);
                break;

            case ConsoleKey.Enter:
                isSelected = true;
                if (selectedOption == 1)
                {
                    Console.WriteLine("New game selected");
                }
                else if (selectedOption == 2)
                {
                    Console.WriteLine("Load game selected");
                }
                else if (selectedOption == 3)
                {
                    Console.WriteLine("View highscores selected");
                }
                else if (selectedOption == 4)
                {
                    Console.WriteLine("Quit selected");
                    Environment.Exit(0);
                }
                break;
        }
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

