using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {            
            int people = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hall = null;
            decimal price = 0.0m;
            decimal priceWithDiscount = 0.0m;

            if (people > 0 && people <= 50)
            {
                hall = "Small Hall";
                price = 2500.0m;
            }
            else if (people > 50 && people <= 100)
            {
                hall = "Terrace";
                price = 5000.0m;
            }
            else if (people > 100 && people <= 120)
            {
                hall = "Great Hall";
                price = 7500.0m;
            }

            if (package == "Normal")
            {
                price += 500m;
                priceWithDiscount = price - (price * 0.05m);
            }
            else if (package == "Gold")
            {
                price += 750m;
                priceWithDiscount = price - (price * 0.1m);
            }
            else if (package == "Platinum")
            {
                price += 1000m;
                priceWithDiscount = price - (price * 0.15m);
            }

            decimal pricePerPerson = priceWithDiscount / people;

            if (people <= 120)
            {
                Console.WriteLine($"We can offer you the {hall}\nThe price per person is {pricePerPerson:f2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
