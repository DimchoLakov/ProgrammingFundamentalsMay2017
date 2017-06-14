using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] firstArrayOfWords = Console.ReadLine().Split(' ');
            string[] secondArrayOfWords = Console.ReadLine().Split(' ');

            int shorterArray = Math.Min(firstArrayOfWords.Length, secondArrayOfWords.Length);
            int countLeftToRight = 0;
            int countRightToLeft = 0;

            for (int i = 0; i < shorterArray; i++)
            {
                if (firstArrayOfWords[i] == secondArrayOfWords[i])
                {
                    countLeftToRight++;
                }
                else if (firstArrayOfWords[firstArrayOfWords.Length - 1 - i] == secondArrayOfWords[secondArrayOfWords.Length - 1 - i])
                {
                    countRightToLeft++;
                }
            }            
            Console.WriteLine(Math.Max(countLeftToRight, countRightToLeft));
        }
    }
}
