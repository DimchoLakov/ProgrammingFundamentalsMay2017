using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.JumpAround
{
    class JumpAround
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int index = 0;
            long sum = 0;
            // 3 7 12 2 10
            // 0  1  2  3  4
            while (true)
            {
                int step = index;
                sum += numbers[index];
                index += numbers[index];
                if (index > numbers.Length - 1)
                {
                    index = step - numbers[step];
                    if (index < 0)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
