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

        internal void Addition(User user)
        {
            Random random = new Random();
            firstNum = random.Next(1, 99);
            secondNum = random.Next(1, 99);

            Console.Write($"{tabs}{firstNum} + {secondNum} = ? ");
            answer = Console.ReadLine();

            while (int.Parse(answer) != firstNum + secondNum)
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
                Menu.GameSelectMenu(user);
            }
            else
            {
                Addition(user);
            }

        }

        internal void Subtraction(User user)
        {
            Random random = new Random();
            firstNum = random.Next(1, 99);
            secondNum = random.Next(1, 99);

            Console.Write($"{tabs}{firstNum} - {secondNum} = ? ");
            answer = Console.ReadLine();

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
                Menu.GameSelectMenu(user);
            }
            else
            {
                Subtraction(user);
            }
        }

        internal void Multiplication(User user)
        {
            Random random = new Random();
            firstNum = random.Next(1, 99);
            secondNum = random.Next(1, 99);

            Console.Write($"\t\t\t\t{firstNum} x {secondNum} = ? ");
            answer = Console.ReadLine();

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
                Menu.GameSelectMenu(user);
            }
            else
            {
                Multiplication(user);
            }
        }

        internal void Division(User user)
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
                Menu.GameSelectMenu(user);
            }
            else
            {
                Division(user);
            }
        }


    }
}
