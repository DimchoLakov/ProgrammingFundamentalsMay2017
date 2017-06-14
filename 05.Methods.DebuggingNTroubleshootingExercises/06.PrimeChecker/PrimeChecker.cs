using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            bool isPrime = CheckIsPrime(num);
            Console.WriteLine(isPrime);
        }

        static bool CheckIsPrime(long num)
        {

            if (num == 0 || num == 1)
            {
                return false;
            }
            if (num == 2)
            {
                return true;
            }

            for (long currentNum = 2; currentNum <= Math.Sqrt(num); currentNum++)
            {
                if (num % currentNum == 0)
                {
                    return false;
                }          
            }
            return true;
        }
    }
}
