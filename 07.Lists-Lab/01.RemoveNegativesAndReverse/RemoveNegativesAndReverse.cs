using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> removedNegatives = new List<int>(numbers.Count);

            for (int currentIndex = 0; currentIndex < numbers.Count; currentIndex++)
            {
                if (numbers[currentIndex] > 0)
                {
                    removedNegatives.Add(numbers[currentIndex]);
                }
            }
            removedNegatives.Reverse();
            if (removedNegatives.Count > 0)
            {
                Console.WriteLine(string.Join(" ", removedNegatives));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
