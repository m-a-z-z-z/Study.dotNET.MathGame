namespace MathGame.Model;

internal class GameEngine
{
    internal void PlayGame(Game game, char mathOperator)
    {
        Random random = new Random();
        string tabs = "\t\t\t\t";
        string userAnswer;
        int correctAnswer = 0;
        int firstNum = random.Next(1, 99);
        int secondNum = random.Next(1, 99);

        switch (mathOperator)
        {
            case '+':
                correctAnswer = firstNum + secondNum;
                break;
            case '-':
                correctAnswer = firstNum - secondNum;
                break;
            case '*':
                correctAnswer = firstNum * secondNum;
                break;
            case '/':
                while (firstNum % secondNum != 0)
                {
                    firstNum = random.Next(1, 99);
                    secondNum = random.Next(1, 99);
                }
                correctAnswer = firstNum / secondNum;
                break;

        }

        Console.Write($"{tabs}{firstNum} {mathOperator} {secondNum} = ? ");
        userAnswer = Console.ReadLine();

        userAnswer = Helper.ValidateNumber(userAnswer);

        while (int.Parse(userAnswer) != correctAnswer)
        {
            Console.WriteLine($"{tabs}Incorrect. Score reset. Try again.\n");
            game.Score = 0;
            Console.Write($"\t\t\t\t{firstNum} {mathOperator} {secondNum} = ? ");
            userAnswer = Console.ReadLine();
        }

        game.Score++;   // if it gets here, you got it right so increment score

        Console.WriteLine($"{tabs}Correct!\n{tabs}Score: {game.Score}\n");
        Console.Write($"{tabs}Press enter to continue.\n{tabs}R - Return to game select\n{tabs}");
        var continueOrReturn = Console.ReadLine();

        if (continueOrReturn.Trim().ToUpper() == "R")
        {
            Console.Clear();
            Helper.SaveGame(game);
            Menu.GameSelectMenu();
        }
        else
        {
            PlayGame(game, mathOperator);
        }
    }

}
