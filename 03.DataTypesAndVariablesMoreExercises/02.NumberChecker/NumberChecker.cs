using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NumberChecker
{
    class NumberChecker
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long integerNumber;
            if (long.TryParse(input, out integerNumber))
            {
                Console.WriteLine("integer");
            }
            else
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
