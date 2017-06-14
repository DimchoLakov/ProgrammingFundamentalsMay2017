using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            int[] arrOne = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arrTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arrResult = new int[Math.Max(arrOne.Length, arrTwo.Length)];
            for (int i = 0; i < arrResult.Length; i++)
            {
                arrResult[i] = arrOne[i % arrOne.Length] + arrTwo[i % arrTwo.Length];
            }
            Console.WriteLine(string.Join(" ", arrResult));
        }
    }
}
