using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MaxSequenceOfIncreasingElements
{
    class MaxSequenceOfIncreasingElements
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int startIndex = 0;
            int seqLength = 1;

            int bestStartIndex = 0;
            int longestSeq = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] < nums[i])
                {
                    seqLength++;
                    if (seqLength > longestSeq)
                    {
                        longestSeq = seqLength;
                        bestStartIndex = startIndex;
                    }
                }
                else
                {
                    startIndex = i;
                    seqLength = 1;
                }
            }

            for (int i = bestStartIndex; i < longestSeq + bestStartIndex; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
