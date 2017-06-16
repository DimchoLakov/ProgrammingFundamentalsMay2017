using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LINQ.SumMinMaxAverage
{
    class SumMinMaxAverage
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] numbers = new double[n];

            List<double> list = new List<double>(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                list[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Sum = {list.Sum()}");
            Console.WriteLine($"Min = {list.Min()}");
            Console.WriteLine($"Max = {list.Max()}");
            Console.WriteLine($"Average = {list.Average()}");
        }
    }
}
