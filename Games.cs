using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Games
    {
        //User user = new User();
        string tabs = "\t\t\t\t";
        string? answer;
        int firstNum;
        int secondNum;
        int result;
        int score;

        internal void Addition()
        {
            Random random = new Random();
            firstNum = random.Next(1, 99);
            secondNum = random.Next(1, 99);

            Console.Write($"{tabs}{firstNum} + {secondNum} = ? ");
            answer = Console.ReadLine();

            while (int.Parse(answer) != firstNum + secondNum)
            {
                Console.WriteLine($"{tabs}Incorrect. Score reset. Try again.\n");
                score = 0;
                Console.Write($"\t\t\t\t{firstNum} + {secondNum} = ? ");
                answer = Console.ReadLine();
            }

            score++;
            Console.WriteLine($"{tabs}Correct!\n{tabs}Score: {score}\n");
            Console.Write($"{tabs}Press enter to continue.\n{tabs}R - Return to game select\n{tabs}");
            var continueOrReturn = Console.ReadLine();

            if (continueOrReturn.Trim().ToUpper() == "R")
            {
                Menu.GameSelectMenu();
            }
            else
            {
                Addition();
            }

        }

        internal void Subtraction()
        {
            Random random = new Random();
            firstNum = random.Next(1, 99);
            secondNum = random.Next(1, 99);

            Console.Write($"{tabs}{firstNum} - {secondNum} = ? ");
            answer = Console.ReadLine();

            while (int.Parse(answer) != firstNum - secondNum)
            {
                Console.WriteLine($"{tabs}Incorrect. Score reset. Try again.\n");
                score = 0;
                Console.Write($"{tabs}{firstNum} - {secondNum} = ? ");
                answer = Console.ReadLine();
            }

            score++;
            Console.WriteLine($"{tabs}Correct!\n{tabs}Score: {score}\n");
            Console.Write($"{tabs}Press enter to continue.\n{tabs}R - Return to game select\n{tabs}");
            var continueOrReturn = Console.ReadLine();

            if (continueOrReturn.Trim().ToUpper() == "R")
            {
                Menu.GameSelectMenu();
            }
            else
            {
                Subtraction();
            }
        }

        internal void Multiplication()
        {
            Random random = new Random();
            firstNum = random.Next(1, 99);
            secondNum = random.Next(1, 99);

            Console.Write($"\t\t\t\t{firstNum} x {secondNum} = ? ");
            answer = Console.ReadLine();

            while (int.Parse(answer) != firstNum * secondNum)
            {
                Console.WriteLine($"{tabs}Incorrect. Score reset. Try again.");
                score = 0;
                Console.Write($"\t\t\t\t{firstNum} x {secondNum} = ? ");
                answer = Console.ReadLine();
            }

            score++;
            Console.WriteLine($"{tabs}Correct!\n{tabs}Score: {score}\n");
            Console.Write($"{tabs}Press enter to continue.\n{tabs}R - Return to game select\n{tabs}");
            var continueOrReturn = Console.ReadLine();

            if (continueOrReturn.Trim().ToUpper() == "R")
            {
                Menu.GameSelectMenu();
            }
            else
            {
                Multiplication();
            }
        }

        internal void Division()
        {
            Random random = new Random();
            firstNum = random.Next(1, 99);
            secondNum = random.Next(1, 99);

            while (firstNum % secondNum != 0)
            {
                firstNum = random.Next(1, 99);
                secondNum = random.Next(1, 99);
            }

            Console.Write($"{tabs}{firstNum} / {secondNum} = ? ");
            answer = Console.ReadLine();

            while (int.Parse(answer) != firstNum / secondNum)
            {
                Console.WriteLine($"{tabs}Incorrect. Score reset. Try again.");
                score = 0;
                Console.Write($"{tabs}{firstNum} / {secondNum} = ? ");
                answer = Console.ReadLine();
            }

            score++;
            Console.WriteLine($"{tabs}Correct!\n{tabs}Score: {score}\n");
            Console.Write($"{tabs}Press enter to continue.\n{tabs}R - Return to game select\n{tabs}");
            var continueOrReturn = Console.ReadLine();

            if (continueOrReturn.Trim().ToUpper() == "R")
            {
                Menu.GameSelectMenu();
            }
            else
            {
                Division();
            }
        }


    }
}
