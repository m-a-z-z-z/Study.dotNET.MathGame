using System.ComponentModel.Design;
using MathGame;

// Var declartion
string? username = null;
var random = new Random();
int firstNum;
int secondNum;
int result;
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
                    Console.Clear();
                    Console.CursorVisible = true;
                    CreateUser();
                }
                else if (selectedOption == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Load game selected");

                }
                else if (selectedOption == 3)
                {
                    Console.Clear();
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
    Console.Write("Enter username to track score: ");
    user.name = Console.ReadLine();
    GameSelect();
}

void GameSelect()
{
    Console.WriteLine("\t\t\tSelect game: ");
    Console.WriteLine("\t\t\tA - Addition");
    Console.WriteLine("\t\t\tS - Subtraction");
    Console.WriteLine("\t\t\tM - Multiplication");
    Console.WriteLine("\t\t\tD - Division");
    Console.WriteLine("\t\t\tR - Return to main menu");
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
        case "R":
            Console.Clear();
            Menu();
            break;
        default:
            Console.WriteLine("Invalid selection");
            break;
    }
}

void Addition()
{
    Console.Clear();
    Console.WriteLine("Addition game selected...");

    firstNum = random.Next(1, 10);
    secondNum = random.Next(1, 10);
    
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
    Console.WriteLine($"Correct!\nScore: {user.score}");
    GameSelect();
}

void Subtraction()
{
    Console.Clear();
    Console.WriteLine("Subtraction game selected...");

    firstNum = random.Next(1, 10);
    secondNum = random.Next(1, 10);

    Console.WriteLine($"{firstNum} - {secondNum} = ?");
    var result = Console.ReadLine();

    while (result != ($"{firstNum - secondNum}"))
    {
        Console.WriteLine("Incorrect. Score reset. Try again.");
        user.score = 0;
        Console.WriteLine($"{firstNum} - {secondNum} = ?");
        result = Console.ReadLine();
    }
    user.score++;
    Console.WriteLine($"Correct!\nScore: {user.score}");
    GameSelect();
}

void Multiplication()
{
    Console.Clear();
    Console.WriteLine("Multiplication game selected...");

    firstNum = random.Next(1, 10);
    secondNum = random.Next(1, 10);

    Console.WriteLine($"{firstNum} x {secondNum} = ?");
    var result = Console.ReadLine();

    while (result != ($"{firstNum * secondNum}"))
    {
        Console.WriteLine("Incorrect. Score reset. Try again.");
        user.score = 0;
        Console.WriteLine($"{firstNum} x {secondNum} = ?");
        result = Console.ReadLine();
    }
    user.score++;
    Console.WriteLine($"Correct!\nScore: {user.score}");
    GameSelect();
}

void Division()
{
    Console.Clear();
    Console.WriteLine("Division game selected...");

    firstNum = random.Next(1, 10);
    secondNum = random.Next(1, 10);

    Console.WriteLine($"{firstNum} / {secondNum} = ?");
    var result = Console.ReadLine();

    while (result != ($"{firstNum / secondNum}"))
    {
        Console.WriteLine("Incorrect. Score reset. Try again.");
        user.score = 0;
        Console.WriteLine($"{firstNum} / {secondNum} = ?");
        result = Console.ReadLine();
    }
    user.score++;
    Console.WriteLine($"Correct!\nScore: {user.score}");
    GameSelect();
}

