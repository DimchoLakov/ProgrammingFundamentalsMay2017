using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _07.SalesReport
{
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public static Sale Parse(string town, string product, double price, double quantity)
        {
            Sale sale = new Sale
            {
                Town = town,
                Product = product,
                Price = price,
                Quantity = quantity
            };
            return sale;
        }
    }

    class SalesByCity
    {
        public string Town { get; set; }
        public double Sales { get; set; }

        public static SalesByCity Parse(string town, double sales)
        {
            SalesByCity newSalesByCity = new SalesByCity
            {
                Town = town,
                Sales = sales
            };
            return newSalesByCity;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Sale> salesList = ReadSales();

            List<SalesByCity> citySales = CalcSales(salesList);

            foreach (SalesByCity salesByCity in citySales.OrderBy(a => a.Town))
            {
                Console.WriteLine($"{salesByCity.Town} -> {salesByCity.Sales:f2}");
            }

        }

        private static List<SalesByCity> CalcSales(List<Sale> salesList)
        {
            Dictionary<string, double> salesDictionary = new Dictionary<string, double>();
            List<SalesByCity> salesByCityList = new List<SalesByCity>();
            foreach (Sale sale in salesList)
            {
                if (! salesDictionary.ContainsKey(sale.Town))
                {
                    salesDictionary[sale.Town] = 0;
                }
                salesDictionary[sale.Town] += sale.Price * sale.Quantity;
            }

            foreach (var salePair in salesDictionary)
            {
                salesByCityList.Add(SalesByCity.Parse(salePair.Key, salePair.Value));
            }
            return salesByCityList;
        }

        private static List<Sale> ReadSales()
        {
            int n = int.Parse(Console.ReadLine());

            List<Sale> salesList = new List<Sale>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                string town = tokens[0];
                string produt = tokens[1];
                double price = double.Parse(tokens[2]);
                double quantity = double.Parse(tokens[3]);

                salesList.Add(Sale.Parse(town, produt, price, quantity));
            }
            return salesList;
        }
    }
}
