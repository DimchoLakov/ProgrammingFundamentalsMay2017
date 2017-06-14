using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.MultiplicationTable2._0
{
    class MultiplicationTable2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            if (m > 10)
            {
                Console.WriteLine($"{n} X {m} = {n * m}");                
            }
            else
            {
                for (int i = m; m <= 10; m++)
                {
                    Console.WriteLine($"{n} X {m} = {n * m}");
                }
            }            
        }
    }
}
