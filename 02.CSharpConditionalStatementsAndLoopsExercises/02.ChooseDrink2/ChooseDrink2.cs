using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChooseDrink2
{
    class ChooseDrink2
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0.0d;
            string drink = null;
            if (profession == "Athlete")
            {
                drink = "Water";
                price = 0.7;
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                drink = "Coffee";
                price = 1.0;
            }
            else if (profession == "SoftUni Student")
            {
                drink = "Beer";
                price = 1.7;
            }
            else
            {
                drink = "Tea";
                price = 1.2;
            }
            double total = price * quantity;
            Console.WriteLine($"The {profession} has to pay {total:f2}.");
        }
    }
}
