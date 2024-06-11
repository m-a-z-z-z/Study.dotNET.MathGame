namespace MathGame.Model;

internal class Menu
{
    internal static GameEngine gameEngine = new GameEngine();
    internal static void MainMenu()
    { 
        Console.CursorVisible = false;
        ConsoleKeyInfo key;
        
        int selectedOption = 1;
        bool isSelected = false;
        (int left, int top) = Console.GetCursorPosition();  // cursor position coordinates look for column num (left) and row num (top). GetCursorPosition will get the current col and row and put it in left and top int variables. 
        string color = "\u001b[32m";    // green in UTF
        string tabs = "\t\t\t\t";

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

            switch (key.Key)
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
                        GameSelectMenu();
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
                        Helper.PrintHistory();

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

    internal static void GameSelectMenu()
    {
        string tabs = "\t\t\t\t";

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
                Game additionGame = new Game(GameType.Addition);
                gameEngine.playGame(additionGame, '+');
                break;
            case "S":
                Console.Clear();
                Console.WriteLine($"{tabs}######### Subtraction game selected... #########\n");
                Game subtractionGame = new Game(GameType.Subtraction);
                gameEngine.playGame(subtractionGame, '-');
                break;
            case "M":
                Console.Clear();
                Console.WriteLine($"{tabs}######### Multiplication game selected... #########\n");
                Game multiplicationGame = new Game(GameType.Multiplication);
                gameEngine.playGame(multiplicationGame, '*');
                break;
            case "D":
                Console.Clear();
                Console.WriteLine($"{tabs}######### Division game selected... #########\n");
                Game divisionGame = new Game(GameType.Division);
                gameEngine.playGame(divisionGame, '/');
                break;
            case "R":
                Console.Clear();
                MainMenu();
                break;
            default:
                Console.WriteLine("Invalid selection");
                break;
        }
    }
}
