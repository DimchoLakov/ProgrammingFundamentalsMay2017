using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            decimal num1 = decimal.Parse(Console.ReadLine());
            decimal num2 = decimal.Parse(Console.ReadLine());

            decimal difference = Math.Abs(num1 - num2);
            decimal eps = 0.000001m;
            bool areEqual = true;
            if (difference >= eps)
            {
                areEqual = false;
            }
            else
            {
                areEqual = true;
            }
            Console.WriteLine(areEqual);
        }
    }
}
