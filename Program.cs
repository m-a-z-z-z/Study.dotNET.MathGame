using System.ComponentModel.Design;
using MathGame;

// Var declartion
string? username = null;
var random = new Random();
int firstNum;
int secondNum;
DateTime date = DateTime.UtcNow;
User user = new User();
int result;

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

        Console.WriteLine("\t\t\t\t##############################################");
        Console.WriteLine("\t\t\t\t#           Welcome to Math Game             #");
        Console.WriteLine("\t\t\t\t#                                            #");
        Console.WriteLine($"\t\t\t\t#{(selectedOption == 1 ? color : "")}                 New game\u001b[0m                   #");
        Console.WriteLine($"\t\t\t\t#{(selectedOption == 2 ? color : "")}                 Load game\u001b[0m                  #");
        Console.WriteLine($"\t\t\t\t#{(selectedOption == 3 ? color : "")}              View highscores\u001b[0m               #");
        Console.WriteLine($"\t\t\t\t#{(selectedOption == 4 ? color : "")}                   Quit\u001b[0m                     #");
        Console.WriteLine("\t\t\t\t#                                            #");
        Console.WriteLine("\t\t\t\t#   Use arrows keys to navigate menu items.  #");
        Console.WriteLine("\t\t\t\t#          Use enter key to select.          #");
        Console.WriteLine("\t\t\t\t##############################################");

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
    Console.Write("\t\t\t\tEnter username to track score: ");
    user.name = Console.ReadLine();
    GameSelect();
}

void GameSelect()
{
    Console.WriteLine("\t\t\t\t##############################################");
    Console.WriteLine("\t\t\t\t#           Select game:                     #");
    Console.WriteLine("\t\t\t\t#           A - Addition                     #");
    Console.WriteLine("\t\t\t\t#           S - Subtraction                  #");
    Console.WriteLine("\t\t\t\t#           M - Multiplication               #");
    Console.WriteLine("\t\t\t\t#           D - Division                     #");
    Console.WriteLine("\t\t\t\t#           R - Return to main menu          #");
    Console.WriteLine("\t\t\t\t##############################################");
    Console.Write("\n\t\t\t\tEnter selection: ");
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
    Console.WriteLine("\t\t\t\t######### Addition game selected... #########\n");

    firstNum = random.Next(1, 99);
    secondNum = random.Next(1, 99);
    
    Console.Write($"\t\t\t\t{firstNum} + {secondNum} = ? ");
    var answer = Console.ReadLine();

    while(int.Parse(answer) != firstNum + secondNum )
    {
        Console.WriteLine("\t\t\t\tIncorrect. Score reset. Try again.");
        user.score = 0;
        Console.Write($"\t\t\t\t{firstNum} + {secondNum} = ? ");
        answer = Console.ReadLine();
    }
    user.score++;
    Console.WriteLine($"\t\t\t\tCorrect!\n\t\t\t\tScore: {user.score}");
    GameSelect();
}

void Subtraction()
{
    Console.Clear();
    Console.WriteLine("\t\t\t\t######### Subtraction game selected... #########\n");

    firstNum = random.Next(1, 99);
    secondNum = random.Next(1, 99);

    Console.Write($"\t\t\t\t{firstNum} - {secondNum} = ? ");
    var answer = Console.ReadLine();

    while (int.Parse(answer) != firstNum - secondNum)
    {
        Console.WriteLine("\t\t\t\tIncorrect. Score reset. Try again.");
        user.score = 0;
        Console.Write($"\t\t\t\t{firstNum} - {secondNum} = ? ");
        answer = Console.ReadLine();
    }
    user.score++;
    Console.WriteLine($"\t\t\t\tCorrect!\n\t\t\t\tScore: {user.score}");
    GameSelect();
}

void Multiplication()
{
    Console.Clear();
    Console.WriteLine("\t\t\t\t######### Multiplication game selected... #########\n");

    firstNum = random.Next(1, 99);
    secondNum = random.Next(1, 99);

    Console.Write($"\t\t\t\t{firstNum} x {secondNum} = ? ");
    var answer = Console.ReadLine();

    while (int.Parse(answer) != firstNum * secondNum)
    {
        Console.WriteLine("\t\t\t\tIncorrect. Score reset. Try again.");
        user.score = 0;
        Console.Write($"\t\t\t\t{firstNum} x {secondNum} = ? ");
        answer = Console.ReadLine();
    }
    user.score++;
    Console.WriteLine($"\t\t\t\tCorrect!\n\t\t\t\tScore: {user.score}");
    GameSelect();
}

void Division()
{
    Console.WriteLine("\t\t\t\t######### Division game selected... #########\n");

    firstNum = random.Next(1, 99);
    secondNum = random.Next(1, 99);

    while (firstNum % secondNum != 0)
    {
        firstNum = random.Next(1, 99);
        secondNum = random.Next(1, 99);
    }

    Console.Write($"\t\t\t\t{firstNum} / {secondNum} = ? ");
    var answer = Console.ReadLine();

    while (int.Parse(answer) != firstNum / secondNum)
    {
        Console.WriteLine("\t\t\t\tIncorrect. Score reset. Try again.");
        user.score = 0;
        Console.Write($"\t\t\t\t{firstNum} / {secondNum} = ? ");
        answer = Console.ReadLine();
    }
    user.score++;
    Console.WriteLine($"\t\t\t\tCorrect!\n\t\t\t\tScore: {user.score}");
    GameSelect();
}

