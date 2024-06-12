namespace MathGame.Model;

internal class Menu
{
    internal static GameEngine gameEngine = new GameEngine();
    private static ConsoleKeyInfo key;
    private static string tabs = "\t\t\t\t";
    private static int selectedOption;
    private static bool isSelected;
    private static string color = "\u001b[32m";    // green in UTF


    internal static void MainMenu()
    { 
        selectedOption = 1;
        isSelected = false;
        Console.CursorVisible = false;
        (int left, int top) = Console.GetCursorPosition();  // cursor position coordinates look for column num (left) and row num (top). GetCursorPosition will get the current col and row and put it in left and top int variables. 

        while (!isSelected)
        {
            Console.SetCursorPosition(left, top);   // Updates the cursor position to the location of the selected menu item.

            // Highlight selected menu item
            // (selectedOption == 1 ? color : "") 
            // ? = do this if condition is true
            // : = else if condition is false
            // if selectedOption is equal to 1, insert color string, else insert empty string

            Console.WriteLine($"{tabs}##############################################");
            Console.WriteLine($"{tabs}#            Welcome to Math Game            #");
            Console.WriteLine($"{tabs}#                                            #");
            Console.WriteLine($"{tabs}#{(selectedOption == 1 ? color : "")}                  Play game\u001b[0m                 #");
            Console.WriteLine($"{tabs}#{(selectedOption == 2 ? color : "")}               View highscores\u001b[0m              #");
            Console.WriteLine($"{tabs}#{(selectedOption == 3 ? color : "")}                    Quit\u001b[0m                    #");
            Console.WriteLine($"{tabs}#                                            #");
            Console.WriteLine($"{tabs}#   Use arrows keys to navigate menu items.  #");
            Console.WriteLine($"{tabs}#          Use enter key to select.          #");
            Console.WriteLine($"{tabs}#                                            #");
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
                        GameSelectMenu();
                    }
                    else if (selectedOption == 2)
                    {
                        Console.Clear();
                        Menu.HighScoreMenu();
                        Console.WriteLine($"\n\n{tabs}Press enter to return to menu");
                        Console.ReadLine();
                        Console.Clear();
                        MainMenu();
                    }
                    else if (selectedOption == 3)
                    {
                        Console.WriteLine($"{tabs}Exiting game...");
                        Environment.Exit(0);
                    }
                    break;
            } // end switch
        } // end while
    }   // end main menu

    internal static void GameSelectMenu()
    {
        selectedOption = 1;
        isSelected = false;
        Console.CursorVisible = false;
        (int left, int top) = Console.GetCursorPosition();

        while(!isSelected)
        {
            Console.SetCursorPosition(left, top);

            Console.WriteLine($"{tabs}##############################################");
            Console.WriteLine($"{tabs}#                                            #");
            Console.WriteLine($"{tabs}#{(selectedOption == 1 ? color : "")}                 Addition\u001b[0m                   #");
            Console.WriteLine($"{tabs}#{(selectedOption == 2 ? color : "")}                Subtraction\u001b[0m                 #");
            Console.WriteLine($"{tabs}#{(selectedOption == 3 ? color : "")}              Multiplication\u001b[0m                #");
            Console.WriteLine($"{tabs}#{(selectedOption == 4 ? color : "")}                 Division\u001b[0m                   #");
            Console.WriteLine($"{tabs}#                                            #");
            Console.WriteLine($"{tabs}#{(selectedOption == 5 ? color : "")}            Return to main menu\u001b[0m             #");
            Console.WriteLine($"{tabs}#                                            #");
            Console.WriteLine($"{tabs}##############################################");

            key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.DownArrow:
                    selectedOption = (selectedOption == 5 ? 1 : selectedOption + 1);
                    break;
                
                case ConsoleKey.UpArrow:
                    selectedOption = (selectedOption == 1 ? 5 : selectedOption - 1);
                    break;
                
                case ConsoleKey.Enter:
                    isSelected = true;
                    if (selectedOption == 1)
                    {
                        Console.Clear();
                        Console.WriteLine($"{tabs}######### Addition game selected... #########\n");
                        Console.CursorVisible = true;
                        Game additionGame = new Game(GameType.Addition);
                        gameEngine.PlayGame(additionGame, '+');
                    }
                    else if (selectedOption == 2)
                    {
                        Console.Clear();
                        Console.WriteLine($"{tabs}######### Subtraction game selected... #########\n");
                        Console.CursorVisible = true;
                        Game subtractionGame = new Game(GameType.Subtraction);
                        gameEngine.PlayGame(subtractionGame, '-');
                    }
                    else if (selectedOption == 3)
                    {
                        Console.Clear();
                        Console.WriteLine($"{tabs}######### Multiplication game selected... #########\n");
                        Console.CursorVisible = true;
                        Game multiplicationGame = new Game(GameType.Multiplication);
                        gameEngine.PlayGame(multiplicationGame, '*');
                    }
                    else if (selectedOption == 4)
                    {
                        Console.Clear();
                        Console.WriteLine($"{tabs}######### Division game selected... #########\n");
                        Console.CursorVisible = true;
                        Game divisionGame = new Game(GameType.Division);
                        gameEngine.PlayGame(divisionGame, '/');
                    }
                    else if (selectedOption == 5)
                    {
                        Console.Clear();
                        MainMenu();
                    }
                    break;
            }   // end of switch
        }   // end of while loop
    }   // end of game select menu

    internal static void HighScoreMenu()
    {
        selectedOption = 1;
        isSelected = false;
        Console.CursorVisible = false;
        (int left, int top) = Console.GetCursorPosition();

        while (!isSelected)
        {
            Console.SetCursorPosition(left, top);

            Console.WriteLine($"{tabs}##############################################");
            Console.WriteLine($"{tabs}#      Select highscores for a game mode     #");
            Console.WriteLine($"{tabs}#                                            #");
            Console.WriteLine($"{tabs}#{(selectedOption == 1 ? color : "")}                 Addition\u001b[0m                   #");
            Console.WriteLine($"{tabs}#{(selectedOption == 2 ? color : "")}                Subtraction\u001b[0m                 #");
            Console.WriteLine($"{tabs}#{(selectedOption == 3 ? color : "")}              Multiplication\u001b[0m                #");
            Console.WriteLine($"{tabs}#{(selectedOption == 4 ? color : "")}                 Division\u001b[0m                   #");
            Console.WriteLine($"{tabs}#                                            #");
            Console.WriteLine($"{tabs}#{(selectedOption == 5 ? color : "")}            Return to main menu\u001b[0m             #");
            Console.WriteLine($"{tabs}#                                            #");
            Console.WriteLine($"{tabs}##############################################");

            key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.DownArrow:
                    selectedOption = (selectedOption == 5 ? 1 : selectedOption + 1);
                    break;

                case ConsoleKey.UpArrow:
                    selectedOption = (selectedOption == 1 ? 5 : selectedOption - 1);
                    break;

                case ConsoleKey.Enter:
                    isSelected = true;
                    if (selectedOption == 1)
                    {
                        Console.Clear();
                        Console.WriteLine($"{tabs}######### Viewing Addition highscores... #########\n");
                        var gamesToPrint = Helper.games.Where(x => x.Score > 0 && x.GameMode == GameType.Addition)
                            .OrderByDescending(x => x.Score)
                            .ThenBy(x => x.Date);
                        Helper.PrintHighscores(gamesToPrint.ToList());
                    }
                    else if (selectedOption == 2)
                    {
                        Console.Clear();
                        Console.WriteLine($"{tabs}######### Viewing Subtraction highscores... #########\n");
                        var gamesToPrint = Helper.games.Where(x => x.Score > 0 && x.GameMode == GameType.Subtraction)
                            .OrderByDescending(x => x.Score)
                            .ThenBy(x => x.Date);
                        Helper.PrintHighscores(gamesToPrint.ToList());
                    }
                    else if (selectedOption == 3)
                    {
                        Console.Clear();
                        Console.WriteLine($"{tabs}######### Viewing Multiplication highscores... #########\n");
                        var gamesToPrint = Helper.games.Where(x => x.Score > 0 && x.GameMode == GameType.Multiplication)
                            .OrderByDescending(x => x.Score)
                            .ThenBy(x => x.Date);
                        Helper.PrintHighscores(gamesToPrint.ToList());
                    }
                    else if (selectedOption == 4)
                    {
                        Console.Clear();
                        Console.WriteLine($"{tabs}######### Viewing Division highscores... #########\n");
                        var gamesToPrint = Helper.games.Where(x => x.Score > 0 && x.GameMode == GameType.Division)
                            .OrderByDescending(x => x.Score)
                            .ThenBy(x => x.Date);
                        Helper.PrintHighscores(gamesToPrint.ToList());
                    }
                    else if (selectedOption == 5)
                    {
                        Console.Clear();
                        MainMenu();
                    }
                    break;
            }   // end of switch
        }   // end of while loop
    }
}
