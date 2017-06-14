using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ArrayStatistics
{
    class ArrayStatistics
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int biggestNumber = int.MinValue;
            int smallestNumber = int.MaxValue;
            int sum = 0;
            double average = 0d;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > biggestNumber)
                {
                    biggestNumber = nums[i];
                }
                if (nums[i] < smallestNumber)
                {
                    smallestNumber = nums[i];
                }
                sum += nums[i];
                average = sum / (i + 1.0);
            }
            Console.WriteLine($"Min = {smallestNumber}");
            Console.WriteLine($"Max = {biggestNumber}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
