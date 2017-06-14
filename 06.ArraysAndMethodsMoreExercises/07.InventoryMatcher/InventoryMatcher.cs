using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.InventoryMatcher
{
    class InventoryMatcher
    {
        static void Main(string[] args)
        {
            string[] productNames = Console.ReadLine().Split(' ').ToArray();
            long[] quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] priceOfProduct = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "done")
                {
                    break;
                }
                for (int i = 0; i < productNames.Length; i++)
                {
                    if (input == productNames[i])
                    {
                        Console.WriteLine($"{input} costs: {priceOfProduct[i]}; Available quantity: {quantities[i]}");
                    }
                }
            }
        }
    }
}
