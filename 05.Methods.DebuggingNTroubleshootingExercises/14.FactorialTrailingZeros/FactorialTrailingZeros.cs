using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14.FactorialTrailingZeros
{
    class FactorialTrailingZeros
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = FindFactorial(n);
            int trailingZeros = FindTrailingZeros(factorial);
            Console.WriteLine(trailingZeros);
        }

        static int FindTrailingZeros(BigInteger factorial)
        {
            string trailingZeros = factorial.ToString();
            int zeroCounter = 0;
            int currentNum = 0;
            for (int i = trailingZeros.Length - 1; i >= 0; i--)
            {
                currentNum = int.Parse(trailingZeros[i].ToString());
                if (currentNum % 10 == 0)
                {
                    zeroCounter++;
                }
                else
                {
                    break;
                }
            }
            return zeroCounter;
        }

        static BigInteger FindFactorial(int n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
