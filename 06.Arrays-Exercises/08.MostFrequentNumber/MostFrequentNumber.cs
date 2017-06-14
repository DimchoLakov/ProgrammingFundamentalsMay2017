using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int mostFrequentNumber = 0;
            int maxCounter = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                int currentCnt = 0;
                for (int j = i; j < sequence.Length; j++)
                {                    
                    if (sequence[i] == sequence[j])
                    {
                        currentCnt++;
                    }                    
                }
                if (currentCnt > maxCounter)
                {
                    maxCounter = currentCnt;
                    mostFrequentNumber = sequence[i];
                }
            }
            Console.WriteLine(mostFrequentNumber);
        }
    }
}
