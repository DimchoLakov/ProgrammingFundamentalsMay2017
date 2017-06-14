using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.MasterNumbers
{
    class MasterNumbers
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int currentNumber = 0;
            for (currentNumber = 1; currentNumber <= num; currentNumber++)
            {
                if (IsPalindrome(currentNumber) && IsSumOfDigitsDivisibleBy7(currentNumber) && ContainsEvenDigit(currentNumber))
                {
                    Console.WriteLine(currentNumber);
                }                
            }
        }

        static bool ContainsEvenDigit(int currentNumber)
        {
            string numberToString = currentNumber.ToString();
            for (int i = 0; i < numberToString.Length; i++)
            {
                // lastDigit = int.Parse(numberToString[i].ToString());
                if (numberToString[i] % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        static bool IsSumOfDigitsDivisibleBy7(int currentNumber)
        {
            int sum = 0;
            int num = currentNumber;
            string str = currentNumber.ToString();
            for (int i = 0; i < str.Length; i++)
            {
                currentNumber = currentNumber % 10;
                sum += currentNumber;
                num = num / 10;
                currentNumber = num;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            return false;
        }

        static bool IsPalindrome(int currentNumber)
        {
            string str = currentNumber.ToString();
            if (str.Length < 4 && str[0] == str[str.Length - 1])
            {
                return true;
            }
            else if (str.Length < 6 &&
                (str[0] == str[str.Length - 1] && str[1] == str[str.Length - 2]))
            {
                return true;
            }
            else if (str.Length < 8 &&
               (str[0] == str[str.Length - 1] && str[1] == str[str.Length - 2]
               && str[2] == str[str.Length - 3]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
