using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _04.GrabAndGo
{
    class GrabAndGo
    {
        static void Main(string[] args)
        {
            int[] myArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int specialNumber = int.Parse(Console.ReadLine());
            BigInteger sum = 0;
            int newIndex = 0;
            int specialCounter = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == specialNumber)
                {
                    newIndex = i;
                }
            }

            for (int i = newIndex - 1; i >= 0; i--)
            {
                sum += myArray[i];
                specialCounter++;
            }
            if (specialCounter != 0)
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
