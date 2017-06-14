using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.GameOfNumbers
{
    class GameOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = n; i <= m; i++)
            {
                for (int k = n; k <= m; k++)
                {
                    counter++;
                    if (k + i == magicNumber)
                    {
                        Console.WriteLine($"Number found! {k} + {i} = {magicNumber}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
        }
    }
}
