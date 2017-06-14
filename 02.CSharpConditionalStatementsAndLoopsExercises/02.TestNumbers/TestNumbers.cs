using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TestNumbers
{
    class TestNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int sumBoundary = int.Parse(Console.ReadLine());
            int counter = 0;
            int sum = 0;
            for (int i = n; i >= 1; i--)
            {
                for (int k = 1; k <= m; k++)
                {                    
                    counter++;
                    int multiply = i * k;
                    int multiplyBy3 = multiply * 3;
                    sum += multiplyBy3;
                    if (sum >= sumBoundary)
                    {
                        Console.WriteLine($"{counter} combinations");
                        Console.WriteLine($"Sum: {sum} >= {sumBoundary}");
                        return;
                    }                    
                }
            }
            Console.WriteLine($"{counter} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
