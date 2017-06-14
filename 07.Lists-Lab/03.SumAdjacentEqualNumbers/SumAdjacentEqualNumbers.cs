using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            decimal sum = 0m;
            int index = 1;

            while (index < numbers.Count)
            {
                if (numbers[index - 1] == numbers[index])
                {
                    sum = numbers[index - 1] + numbers[index];
                    numbers.RemoveAt(index - 1);
                    numbers.RemoveAt(index - 1);
                    numbers.Insert(index - 1, sum);
                    if (index > 1)
                    {
                        index--;
                    }
                }
                else
                {
                    index++;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
