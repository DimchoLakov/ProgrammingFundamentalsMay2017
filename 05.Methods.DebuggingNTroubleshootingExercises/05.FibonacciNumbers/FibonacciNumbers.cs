using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fibonacciNumbers = GetFibonacciNumbers(n);
            Console.WriteLine(fibonacciNumbers);
        }

        static int GetFibonacciNumbers(int n)
        {
            int f0 = 0;
            int f1 = 1;
            int fNext = 0;
            for (int i = 1; i <= n; i++)
            {
                fNext = f0;
                f0 = f1;
                f1 = fNext + f1;
            }
            return f1;
        }
    }
}
