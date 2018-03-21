using System;
using System.Globalization;

namespace _01.SoftUniCoffeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            int ordersCount = int.Parse(Console.ReadLine());
            decimal total = 0m;
            for (int i = 0; i < ordersCount; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), @"d/M/yyyy",
                    CultureInfo.InvariantCulture);
                long capsulesCount = long.Parse(Console.ReadLine());

                long daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                decimal coffeePrice = (daysInMonth * capsulesCount) * pricePerCapsule;
                total += coffeePrice;

                Console.WriteLine($"The price for the coffee is: ${coffeePrice:f2}");
            }
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
