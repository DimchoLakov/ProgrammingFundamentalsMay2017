using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DrawAFilledSquare
{
    class DrawAFilledSquare
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintHeaderFooterLine(n);
            for (int i = 1; i <= n - 2; i++)
            {
                PrintMiddleRows(n);
            }
            PrintHeaderFooterLine(n);
        }

        static void PrintHeaderFooterLine(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        static void PrintMiddleRows(int n)
        {
            Console.Write('-');
            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }        
    }
}
