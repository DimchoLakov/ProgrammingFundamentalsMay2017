using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TripleSum
{
    class TripleSum
    {
        static void Main(string[] args)
        {
            int[] arrayOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = 0;
            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                for (int j = i + 1; j < arrayOfIntegers.Length; j++)
                {
                    int sum = arrayOfIntegers[i] + arrayOfIntegers[j];
                    if (arrayOfIntegers.Contains(sum))
                    {
                        count++;
                        Console.WriteLine($"{arrayOfIntegers[i]} + {arrayOfIntegers[j]} == {sum}");
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
