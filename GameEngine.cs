using MathGame.Model;

namespace MathGame;

internal class GameEngine
{
    internal void playGame(Game game, char mathOperator)
    {
        Random random = new Random();
        string tabs = "\t\t\t\t";
        string? userAnswer;
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

        while (int.Parse(userAnswer) != correctAnswer)
        {
            Console.WriteLine($"{tabs}Incorrect. Score reset. Try again.\n");
            game.score = 0;
            Console.Write($"\t\t\t\t{firstNum} {mathOperator} {secondNum} = ? ");
            userAnswer = Console.ReadLine();
        }

        game.score++;   // if it gets here, you got it right so increment score

        Console.WriteLine($"{tabs}Correct!\n{tabs}Score: {game.score}\n");
        Console.Write($"{tabs}Press enter to continue.\n{tabs}R - Return to game select\n{tabs}");
        var continueOrReturn = Console.ReadLine();

        if (continueOrReturn.Trim().ToUpper() == "R")
        {
            Menu.GameSelectMenu();
        }
        else
        {
            playGame(game, mathOperator);
        }
    }

}
