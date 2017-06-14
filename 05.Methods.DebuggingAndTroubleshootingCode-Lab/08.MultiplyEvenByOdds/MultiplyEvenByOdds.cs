using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MultiplyEvenByOdds
{
    class MultiplyEvenByOdds
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multiplySums = GetMultiplyOfEvensByOdds(n);
            Console.WriteLine(multiplySums);
        }

        static int GetMultiplyOfEvensByOdds(int n)
        {
            int sumEvens = GetSumOfEvens(n);
            int sumOdds = GetSumOfOdds(n);
            return sumEvens * sumOdds;
        }

        static int GetSumOfOdds(int n)
        {
            int sum = 0;
            n = Math.Abs(n);
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

        static int GetSumOfEvens(int n)
        {
            n = Math.Abs(n);
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }
    }
}
