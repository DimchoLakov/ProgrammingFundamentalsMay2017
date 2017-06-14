using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ExtractMiddleElements
{
    class ExtractMiddleElements
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (nums.Length == 1)
            {
                Console.WriteLine($"{{ {nums[0]} }}");
            }
            else if (nums.Length % 2 == 0)
            {
                Console.WriteLine("{ " + string.Join(", ", nums[nums.Length / 2 - 1], nums[nums.Length / 2]) + " }");
            }
            else if (nums.Length % 2 == 1)
            {
                Console.WriteLine("{ " + string.Join(", ", nums[nums.Length / 2 - 1], nums[nums.Length / 2], nums[nums.Length / 2 + 1]) + " }");
            }
        }
    }
}
