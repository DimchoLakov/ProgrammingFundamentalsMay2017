using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.UpgradedMatcher
{
    class UpgradedMatcher
    {
        static void Main(string[] args)
        {
            string[] productNames = Console.ReadLine().Split(' ');
            long[] quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] priceOfProduct = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            while (true)
            {
                string[] inputProduct = Console.ReadLine().Split(' ');
                if (inputProduct[0] == "done")
                {
                    break;
                }

                long quantityNeeded = long.Parse(inputProduct[1]);

                int index = Array.IndexOf(productNames, inputProduct[0]); 
                int quantityLgth = quantities.Length;

                if (index >= quantityLgth)
                {
                    quantities = new long[quantityLgth + index];
                    for (int i = 0; i < quantityLgth; i++)
                    {
                        quantities[quantityLgth - 1 + i] = 0;
                    }
                }

                if (quantities[index] >= quantityNeeded)
                {
                    decimal price = priceOfProduct[index] * quantityNeeded;
                    quantities[index] -= quantityNeeded;
                    Console.WriteLine($"{inputProduct[0]} x {quantityNeeded} costs {price:f2}");
                }
                else
                {
                    Console.WriteLine($"We do not have enough {inputProduct[0]}");
                }
            }
        }
    }
}
