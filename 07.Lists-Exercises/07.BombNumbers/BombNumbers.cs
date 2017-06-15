using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] specials = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int specialNumber = specials[0];
            int powerRange = specials[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNum = numbers[i];

                if (currentNum == specialNumber)
                {
                    int leftIndex = Math.Max(i - powerRange, 0);
                    int rightIndex = Math.Min(i + powerRange, numbers.Count - 1);

                    int removeCount = rightIndex - leftIndex + 1;

                    numbers.RemoveRange(leftIndex, removeCount);

                    i = -1;
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}