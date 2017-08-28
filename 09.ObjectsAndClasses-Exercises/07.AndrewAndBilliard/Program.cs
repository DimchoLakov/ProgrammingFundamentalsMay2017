using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AndrewAndBilliard
{
    class Customer
    {
        public string Name { get; set; }
        public double Bill { get; set; }
        public Dictionary<string, double> ShopList { get; set; }

    }
    class Program
    {
        static void Main()
        {

            Dictionary<string, double> productsPrices = new Dictionary<string, double>();
            int numberOfItems = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfItems; i++)
            {
                string[] tokens = Console.ReadLine().Split('-');
                string productName = tokens[0];
                double price = double.Parse(tokens[1]);

                if (!productsPrices.ContainsKey(tokens[0]))
                {
                    productsPrices.Add(tokens[0], double.Parse(tokens[1]));
                }
                else
                {
                    productsPrices[tokens[0]] = double.Parse(tokens[1]);
                }

            }
            List<Customer> customerList = new List<Customer>();

            string input = Console.ReadLine();

            while (input != "end of clients")
            {
                string[] clientInput = input.Split('-', ',');
                string name = clientInput[0];
                string product = clientInput[1];
                double quantity = double.Parse(clientInput[2]);

                if (!productsPrices.ContainsKey(product))
                {
                    input = Console.ReadLine();
                    continue;
                }

                Customer client = new Customer();

                client.Name = name;
                client.ShopList = new Dictionary<string, double>();
                client.ShopList.Add(product, quantity);

                if (customerList.Any(e => e.Name == name))
                {
                    Customer existingCustomer = customerList.First(e => e.Name == name);

                    if (existingCustomer.ShopList.ContainsKey(product))
                    {
                        existingCustomer.ShopList[product] += quantity;
                    }
                    else
                    {
                        existingCustomer.ShopList[product] = quantity;
                    }
                }
                else
                {
                    customerList.Add(client);
                }
                input = Console.ReadLine();
            }

            foreach (var customer in customerList)
            {
                foreach (var item in customer.ShopList)
                {
                    foreach (var product in productsPrices)
                    {
                        if (item.Key == product.Key) { customer.Bill += item.Value * product.Value; }
                    }
                }
            }
            double sum = 0;
            foreach (var customer in customerList.OrderBy(a => a.Name).ThenBy(b => b.Bill))
            {
                Console.WriteLine(customer.Name);
                foreach (KeyValuePair<string, double> item in customer.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine("Bill: {0:f2}", customer.Bill);
                sum += customer.Bill;
            }
            Console.WriteLine($"Total bill: {sum:f2}");
        }
    }
}
