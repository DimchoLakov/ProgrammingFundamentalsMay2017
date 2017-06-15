using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            List<int> seqOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;
            for (int i = 0; i < seqOfNumbers.Count; i++)
            {
                int currentNumber = seqOfNumbers[i];
                int result = 0;
                while (currentNumber > 0)
                {
                    int temp = currentNumber % 10;
                    result = result * 10 + temp;
                    currentNumber = currentNumber / 10;
                }
                sum += result;
            }
            Console.WriteLine(sum);
        }
    }
}
