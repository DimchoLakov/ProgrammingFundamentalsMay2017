using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SearchForANumber
{
    class SearchForANumber
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] arrWithNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberOfElementsToTake = arrWithNums[0];
            int numberOfElementsToDelete = arrWithNums[1];
            int searchNumber = arrWithNums[2];
            List<int> result = new List<int>(numbers);

            for (int i = 0; i < numberOfElementsToTake; i++)
            {
                result[i] = numbers[i];
            }

            result.RemoveRange(0, numberOfElementsToDelete);

            if (result.Contains(searchNumber))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
