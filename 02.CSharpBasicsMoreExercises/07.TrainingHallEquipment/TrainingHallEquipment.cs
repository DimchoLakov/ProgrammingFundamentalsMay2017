using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.TrainingHallEquipment
{
    class TrainingHallEquipment
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfItems = int.Parse(Console.ReadLine());
            int counter = 0;
            double subTotal = 0.0d;

            while (counter < numberOfItems)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                double quantity = double.Parse(Console.ReadLine());
                subTotal += itemPrice * quantity;
                if (quantity <= 1)
                {
                    Console.WriteLine($"Adding {quantity} {itemName} to cart.");                    
                }
                else if (quantity > 1)
                {
                    Console.WriteLine($"Adding {quantity} {itemName}s to cart.");
                }
                counter++;
            }
            Console.WriteLine($"Subtotal: ${Math.Abs(subTotal):f2}");
            if (subTotal <= budget)
            {
                Console.WriteLine($"Money left: ${Math.Abs(budget - subTotal):f2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${Math.Abs(subTotal - budget):f2} more.");
            }            
        }
    }
}
