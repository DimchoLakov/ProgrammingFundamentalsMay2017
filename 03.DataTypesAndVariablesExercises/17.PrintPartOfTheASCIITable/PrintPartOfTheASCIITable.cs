using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.PrintPartOfTheASCIITable
{
    class PrintPartOfTheASCIITable
    {
        static void Main(string[] args)
        {
            int startSymbol = int.Parse(Console.ReadLine());
            int endSymbol = int.Parse(Console.ReadLine());

            for (int symbol = startSymbol; symbol <= endSymbol; symbol++)
            {
                Console.Write($"{(char)symbol} ");
            }
            Console.WriteLine();
        }
    }
}
