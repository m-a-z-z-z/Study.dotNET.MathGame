using System.ComponentModel.Design;
using MathGame;

// Var declartion
string? username = null;
string tabs = "\t\t\t\t";
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

        Console.WriteLine($"{tabs}##############################################");
        Console.WriteLine($"{tabs}#           Welcome to Math Game             #");
        Console.WriteLine($"{tabs}#                                            #");
        Console.WriteLine($"{tabs}#{(selectedOption == 1 ? color : "")}                 New game\u001b[0m                   #");
        Console.WriteLine($"{tabs}#{(selectedOption == 2 ? color : "")}                 Load game\u001b[0m                  #");
        Console.WriteLine($"{tabs}#{(selectedOption == 3 ? color : "")}              View highscores\u001b[0m               #");
        Console.WriteLine($"{tabs}#{(selectedOption == 4 ? color : "")}                   Quit\u001b[0m                     #");
        Console.WriteLine($"{tabs}#                                            #");
        Console.WriteLine($"{tabs}#   Use arrows keys to navigate menu items.  #");
        Console.WriteLine($"{tabs}#          Use enter key to select.          #");
        Console.WriteLine($"{tabs}##############################################");

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
    Console.Write($"{tabs}Enter username to track score: ");
    user.name = Console.ReadLine();
    GameSelect();
}

void GameSelect()
{
    Console.WriteLine($"{tabs}##############################################");
    Console.WriteLine($"{tabs}#           Select game:                     #");
    Console.WriteLine($"{tabs}#           A - Addition                     #");
    Console.WriteLine($"{tabs}#           S - Subtraction                  #");
    Console.WriteLine($"{tabs}#           M - Multiplication               #");
    Console.WriteLine($"{tabs}#           D - Division                     #");
    Console.WriteLine($"{tabs}#           R - Return to main menu          #");
    Console.WriteLine($"{tabs}##############################################");
    Console.Write($"\n{tabs}Enter selection: ");
    var gameSelected = Console.ReadLine();

    switch (gameSelected.Trim().ToUpper())
    {
        case "A":
            Console.Clear();
            Console.WriteLine($"{tabs}######### Addition game selected... #########\n");
            Addition();
            break;
        case "S":
            Console.Clear();
            Console.WriteLine($"{tabs}######### Subtraction game selected... #########\n");
            Subtraction();
            break;
        case "M":
            Console.Clear();
            Console.WriteLine($"{tabs}######### Multiplication game selected... #########\n");
            Multiplication();
            break;
        case "D":
            Console.Clear();
            Console.WriteLine($"{tabs}######### Division game selected... #########\n");
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
    firstNum = random.Next(1, 99);
    secondNum = random.Next(1, 99);
    
    Console.Write($"{tabs}{firstNum} + {secondNum} = ? ");
    var answer = Console.ReadLine();

    while(int.Parse(answer) != firstNum + secondNum )
    {
        Console.WriteLine($"{tabs}Incorrect. Score reset. Try again.\n");
        user.score = 0;
        Console.Write($"\t\t\t\t{firstNum} + {secondNum} = ? ");
        answer = Console.ReadLine();
    }

    user.score++;
    Console.WriteLine($"{tabs}Correct!\n{tabs}Score: {user.score}\n");
    Console.Write($"{tabs}Press enter to continue.\n{tabs}R - Return to game select\n{tabs}");
    var continueOrReturn = Console.ReadLine();

    if (continueOrReturn.Trim().ToUpper() == "R")
    {
        GameSelect();
    }
    else
    {
        Subtraction();
    }

}

void Subtraction()
{
    firstNum = random.Next(1, 99);
    secondNum = random.Next(1, 99);

    Console.Write($"{tabs}{firstNum} - {secondNum} = ? ");
    var answer = Console.ReadLine();

    while (int.Parse(answer) != firstNum - secondNum)
    {
        Console.WriteLine($"{tabs}Incorrect. Score reset. Try again.\n");
        user.score = 0;
        Console.Write($"{tabs}{firstNum} - {secondNum} = ? ");
        answer = Console.ReadLine();
    }

    user.score++;
    Console.WriteLine($"{tabs}Correct!\n{tabs}Score: {user.score}\n");
    Console.Write($"{tabs}Press enter to continue.\n{tabs}R - Return to game select\n{tabs}");
    var continueOrReturn = Console.ReadLine();

    if (continueOrReturn.Trim().ToUpper() == "R")
    {
        GameSelect();
    }
    else
    {
        Subtraction();
    }
}

void Multiplication()
{
    firstNum = random.Next(1, 99);
    secondNum = random.Next(1, 99);

    Console.Write($"\t\t\t\t{firstNum} x {secondNum} = ? ");
    var answer = Console.ReadLine();

    while (int.Parse(answer) != firstNum * secondNum)
    {
        Console.WriteLine($"{tabs}Incorrect. Score reset. Try again.");
        user.score = 0;
        Console.Write($"\t\t\t\t{firstNum} x {secondNum} = ? ");
        answer = Console.ReadLine();
    }

    user.score++;
    Console.WriteLine($"{tabs}Correct!\n{tabs}Score: {user.score}\n");
    Console.Write($"{tabs}Press enter to continue.\n{tabs}R - Return to game select\n{tabs}");
    var continueOrReturn = Console.ReadLine();

    if (continueOrReturn.Trim().ToUpper() == "R")
    {
        GameSelect();
    }
    else
    {
        Subtraction();
    }
}

void Division()
{
    firstNum = random.Next(1, 99);
    secondNum = random.Next(1, 99);

    while (firstNum % secondNum != 0)
    {
        firstNum = random.Next(1, 99);
        secondNum = random.Next(1, 99);
    }

    Console.Write($"{tabs}{firstNum} / {secondNum} = ? ");
    var answer = Console.ReadLine();

    while (int.Parse(answer) != firstNum / secondNum)
    {
        Console.WriteLine($"{tabs}Incorrect. Score reset. Try again.");
        user.score = 0;
        Console.Write($"{tabs}{firstNum} / {secondNum} = ? ");
        answer = Console.ReadLine();
    }

    user.score++;
    Console.WriteLine($"{tabs}Correct!\n{tabs}Score: {user.score}\n");
    Console.Write($"{tabs}Press enter to continue.\n{tabs}R - Return to game select\n{tabs}");
    var continueOrReturn = Console.ReadLine();

    if (continueOrReturn.Trim().ToUpper() == "R")
    {
        GameSelect();
    }
    else
    {
        Subtraction();
    }
}

