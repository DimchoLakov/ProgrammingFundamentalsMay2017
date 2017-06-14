using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CountTheIntegers
{
    class CountTheIntegers
    {
        static void Main(string[] args)
        {
            int a = 0;
            int counter = 0;
            
            while (true)
            {                
                bool tryParse = int.TryParse(Console.ReadLine(), out a);
                if (tryParse)
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
