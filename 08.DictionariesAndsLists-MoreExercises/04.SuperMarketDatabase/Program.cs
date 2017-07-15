using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SuperMarketDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<double, long>> productList = new Dictionary<string, Dictionary<double, long>>();

            long previousQuantity = 0;

            while (input != "stocked")
            {
                string[] tokens = input.Split(' ');

                string productName = tokens[0];
                double productPrice = double.Parse(tokens[1]);
                long productQuantity = long.Parse(tokens[2]);

                bool hasPriceChanged = false;

                if (!productList.ContainsKey(productName))
                {
                    productList.Add(productName, new Dictionary<double, long>());
                    productList[productName].Add(productPrice, productQuantity);
                }
                else
                {
                    if (!productList[productName].ContainsKey(productPrice))
                    {
                        foreach (KeyValuePair<double, long> priceQuantity in productList[productName])
                        {
                            previousQuantity = priceQuantity.Value;
                        }
                        productList[productName] = new Dictionary<double, long>();
                        productList[productName].Add(productPrice, previousQuantity);
                        hasPriceChanged = true;
                    }

                    if (hasPriceChanged && previousQuantity == productList[productName][productPrice])
                    {
                        productList[productName][productPrice] += productQuantity;
                    }

                    if (!productList[productName].ContainsValue(productQuantity))
                    {
                        if (!hasPriceChanged)
                        {
                            productList[productName][productPrice] += productQuantity;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            double grandTotal = 0d;

            foreach (KeyValuePair<string, Dictionary<double, long>> product in productList)
            {
                Console.Write($"{product.Key}: ");

                var priceQuantityPair = product.Value;
                foreach (var priceAndQuantity in priceQuantityPair)
                {
                    double sum = priceAndQuantity.Key * priceAndQuantity.Value;
                    Console.WriteLine($"${priceAndQuantity.Key:f2} * {priceAndQuantity.Value} = ${sum:f2}");
                    grandTotal += priceAndQuantity.Key * priceAndQuantity.Value;
                }
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${grandTotal:f2}");
        }
    }
}
