using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateTheSum
{
    class RotateTheSum
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotateCount = int.Parse(Console.ReadLine());
            int[] sum = new int[nums.Length];

            for (int i = 0; i < rotateCount; i++)
            {
                RotateArray(nums);
                for (int j = 0; j < nums.Length; j++)
                {
                    sum[j] += nums[j];
                }
            }
            Console.WriteLine(string.Join(" ", sum));
        }

        static void RotateArray(int[] nums)
        {
            int lastElement = nums[nums.Length - 1];
            for (int i = nums.Length - 1; i > 0; i--)
            {
                nums[i] = nums[i - 1];
            }
            nums[0] = lastElement;
        }
    }
}
