using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FigureX
{
    class FigureX
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n / 2; row++)
            {
                Console.WriteLine(new string(' ', row) + "x" + new string(' ', (n - 2) - row * 2) + "x");
            }

            Console.WriteLine(new string(' ', n / 2) + "x");
            
            for (int row = 0; row < n / 2; row++)
            {
                Console.WriteLine(new string(' ', (n - 2) / 2 - row) + "x" + new string(' ', 1 + row * 2) + "x");
            }
        }
    }
}
