using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumberInReversedOrder2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            decimal reversedNumbers = GetReverseNumbers(num);
            Console.WriteLine(reversedNumbers);
        }

        static decimal GetReverseNumbers(decimal num)
        {
            string numToString = num.ToString();
            string result = string.Empty;

            for (int i = numToString.Length - 1; i >= 0; i--)
            {
                result += numToString[i];
            }
            return decimal.Parse(result);
        }
    }
}
