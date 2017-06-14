using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DifferentNumbers
{
    class DifferentNumbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    for (int k = a; k <= b; k++)
                    {
                        for (int m = a; m <= b; m++)
                        {
                            for (int n = a; n <= b; n++)
                            {
                                if (i < j && j < k && k < m && m < n)
                                {
                                    Console.WriteLine($"{i} {j} {k} {m} {n}");
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine($"No");
            }
        }
    }
}
