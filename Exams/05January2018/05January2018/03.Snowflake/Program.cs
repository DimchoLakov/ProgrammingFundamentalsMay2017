using System;
using System.Text.RegularExpressions;

namespace _03.Snowflake
{
    class Program
    {
        static void Main()
        {
            string surfacePattern = @"^[^a-zA-Z0-9]+$";
            string mantlePattern = @"^[0-9_]+$";
            string corePattern = @"[a-zA-Z]+";
            string middlePattern = @"^[^a-zA-Z0-9]+[0-9_]+[a-zA-Z]+[0-9_]+[^a-zA-Z0-9]+$";

            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();
            string thirdInput = Console.ReadLine();
            string fourthInput = Console.ReadLine();
            string fifthInput = Console.ReadLine();

            Regex surfaceRegex = new Regex(surfacePattern);
            Regex mantleRegex = new Regex(mantlePattern);
            Regex middleRegex = new Regex(middlePattern);
            Regex coreRegex = new Regex(corePattern);

            string middleLine = middleRegex.Match(thirdInput).ToString();
            int coreLength = coreRegex.Match(middleLine).ToString().Length;

            bool isFirstMatch = surfaceRegex.IsMatch(firstInput);
            bool isFifthMatch = surfaceRegex.IsMatch(fifthInput);
            bool isSecondMatch = mantleRegex.IsMatch(secondInput);
            bool isFourthMatch = mantleRegex.IsMatch(fourthInput);
            bool isMiddleMatch = middleRegex.IsMatch(thirdInput);

            if (isFirstMatch && isSecondMatch && isFourthMatch && isFifthMatch && isMiddleMatch)
            {
                Console.WriteLine($"Valid");
                Console.WriteLine(coreLength);
            }
            else
            {
                Console.WriteLine($"Invalid");
            }
        }
    }
}
