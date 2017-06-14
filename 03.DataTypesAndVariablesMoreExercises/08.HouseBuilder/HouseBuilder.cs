using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.HouseBuilder
{
    class HouseBuilder
    {
        static void Main(string[] args)
        {
            long firstPrice = long.Parse(Console.ReadLine());
            long secondPrice = long.Parse(Console.ReadLine());
            long firstSum = 0;
            long secondSum = 0;
            if (firstPrice < secondPrice)
            {
                firstSum = firstPrice * 4;
                secondSum = secondPrice * 10;
            }
            else
            {
                firstSum = firstPrice * 10;
                secondSum = secondPrice * 4;
            }
            long total = firstSum + secondSum;
            Console.WriteLine(total);
        }
    }
}
