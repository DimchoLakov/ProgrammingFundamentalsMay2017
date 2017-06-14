using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            long startRange = long.Parse(Console.ReadLine());
            long endRange = long.Parse(Console.ReadLine());
            List<long> primesInRange = GetPrimesInRange(startRange, endRange);

            Console.WriteLine(string.Join(", ", primesInRange));
        }

        static List<long> GetPrimesInRange(long startRange, long endRange)
        {
            List<long> primes = new List<long>();
            
            for (long currentNum = startRange; currentNum <= endRange; currentNum++)
            {
                if (IsPrime(currentNum))
                {
                    primes.Add(currentNum);
                }
            }
            return primes;
        }

        static bool IsPrime(long num)
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
