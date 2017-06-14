using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumbersInReversedOrder
{
    class NumbersInReversedOrder
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            PrintNumberInReversedOrder(num);
        }

        static decimal PrintNumberInReversedOrder(decimal num)
        {
            Console.WriteLine(num.ToString().Reverse().Aggregate("", (a, b) => a + b));
            return num;
        }
    }
}
