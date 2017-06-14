using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RoundingNumbersAwayFromZero
{
    class RoundingNumbersAwayFromZero
    {
        static void Main(string[] args)
        {
            //double[] myArray = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    var rounded = Math.Round(myArray[i], MidpointRounding.AwayFromZero);
            //    Console.WriteLine($"{myArray[i]} => {rounded}");
            //}

            double[] myArray = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double temp = 0d;
            double rounded = 0d;
            for (int i = 0; i < myArray.Length; i++)
            {
                temp = myArray[i];
                rounded = Math.Truncate(Math.Abs(myArray[i]) + 0.5);
                if (temp < 0)
                {
                    Console.WriteLine($"{temp} => {rounded * -1}");
                }
                else
                {
                    Console.WriteLine($"{temp} => {rounded}");
                }

            }
        }
    }
}
