using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnglishNameOfTheLastDigit
{
    class EnglishNameOfTheLastDigit
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            GetNameOfLastDigit(n);
        }

        static long GetNameOfLastDigit(long n)
        {
            string lastDigitToText = null;
            switch (Math.Abs(n % 10))
            {
                case 0:
                    lastDigitToText = "zero";
                    break;
                case 1:
                    lastDigitToText = "one";
                    break;
                case 2:
                    lastDigitToText = "two";
                    break;
                case 3:
                    lastDigitToText = "three";
                    break;
                case 4:
                    lastDigitToText = "four";
                    break;
                case 5:
                    lastDigitToText = "five";
                    break;
                case 6:
                    lastDigitToText = "six";
                    break;
                case 7:
                    lastDigitToText = "seven";
                    break;
                case 8:
                    lastDigitToText = "eight";
                    break;
                case 9:
                    lastDigitToText = "nine";
                    break;
            }
            Console.WriteLine(lastDigitToText);
            return n;
        }
    }
}
