using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Array.Sort(numbers);

            int count = 1;
            for (int index = 1; index < numbers.Length; index++)
            {
                if (numbers[index - 1] == numbers[index])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine(numbers[index - 1] + " -> " + count);
                    count = 1;
                }
            }
            Console.WriteLine(numbers[numbers.Length - 1] + " -> " + count);
        }
    }
}
