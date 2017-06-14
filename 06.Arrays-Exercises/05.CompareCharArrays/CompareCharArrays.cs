using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] arrOne = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] arrTwo = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int shorterArray = Math.Min(arrOne.Length, arrTwo.Length);
            bool isEqual = false;
            bool isFirstSmaller = true;
            for (int i = 0; i < shorterArray; i++)
            {
                if (arrOne[i] == arrTwo[i])
                {
                    isEqual = true;
                }
                else if (arrOne[i] < arrTwo[i])
                {
                    isFirstSmaller = true;
                }
                else
                {
                    isFirstSmaller = false;
                }
            }
            if (isEqual)
            {
                if (arrOne.Length < arrTwo.Length)
                {
                    Console.WriteLine(arrOne);
                    Console.WriteLine(arrTwo);
                }
                else
                {
                    Console.WriteLine(arrTwo);
                    Console.WriteLine(arrOne);
                }
            }
            else if (isFirstSmaller)
            {
                Console.WriteLine(arrOne);
                Console.WriteLine(arrTwo);
            }
            else
            {
                Console.WriteLine(arrTwo);
                Console.WriteLine(arrOne);
            }
        }
    }
}
