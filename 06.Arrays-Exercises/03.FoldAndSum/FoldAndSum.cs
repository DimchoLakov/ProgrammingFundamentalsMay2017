using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] sum = new int[nums.Length / 2];
            for (int i = 0; i < nums.Length / 4; i++)
            {
                int firstRows = nums[i] + nums[nums.Length / 2 - i - 1];
                int secondRows = nums[nums.Length / 2 + i] + nums[nums.Length - 1 - i];
                sum[i] = firstRows;
                sum[sum.Length - i - 1] = secondRows;
            }
            for (int i = sum.Length / 2 - 1; i >= 0; i--)
            {
                Console.Write(sum[i] + " ");
            }
            for (int i = sum.Length - 1; i > sum.Length / 2 - 1; i--)
            {
                Console.Write(sum[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
