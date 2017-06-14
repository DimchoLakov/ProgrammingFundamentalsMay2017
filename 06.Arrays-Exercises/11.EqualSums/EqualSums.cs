using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EqualSums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            //int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            //int sumTotal = 0;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    sumTotal += nums[i];
            //}

            //int leftSum = 0;
            //int rightSum = 0;

            //for (int i = 1; i < nums.Length; i++)
            //{
            //    leftSum += nums[i - 1];
            //    rightSum = sumTotal - nums[i] - sumTotal;
            //    if (leftSum == rightSum)
            //    {
            //        int indexWithBiggestNum = Array.IndexOf(nums, nums[i]);
            //        Console.WriteLine(indexWithBiggestNum);
            //        break;
            //    }
            //}
            int[] number = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i <= number.Length - 1; i++)
            {
                if (number.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }
                sumLeft = 0;
                for (int iLeft = i; iLeft > 0; iLeft--)
                {
                    int nextPosition = iLeft - 1;
                    if (iLeft > 0)
                    {
                        sumLeft += number[nextPosition];
                    }
                }

                sumRight = 0;
                for (int iRight = i; iRight < number.Length; iRight++)
                {
                    int nextPosition = (iRight + 1);
                    if (iRight < number.Length - 1)
                    {
                        sumRight += number[nextPosition];
                    }
                }

                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    return;
                }

            }
            Console.WriteLine("no");
        }
    }
}
