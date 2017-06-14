using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SumOfOddNumbers
{
    class SumOfOddNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {                
                Console.WriteLine(counter);
                sum += counter;
                counter += 2;                
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
