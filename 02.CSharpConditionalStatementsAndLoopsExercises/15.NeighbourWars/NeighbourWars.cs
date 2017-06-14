using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NeighbourWars
{
    class NeighbourWars
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Pesho's damage: ");
            int peshoDamage = int.Parse(Console.ReadLine());
            Console.Write("Enter Gosho's damage: ");
            int goshoDamage = int.Parse(Console.ReadLine());
            string peshoAttack = "Roundhouse kick";
            string goshoAttack = "Thunderous fist";
            int peshoHealth = 100;
            int goshoHealth = 100;
            int roundCounter = 0;

            while (true)
            {
                roundCounter++;
                if (roundCounter % 2 == 1)
                {
                    goshoHealth -= peshoDamage;
                    if (goshoHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {roundCounter}th round.");
                        break;
                    }
                    Console.WriteLine($"Pesho used {peshoAttack} and reduced Gosho to {goshoHealth} health.");
                }
                else if (roundCounter % 2 == 0)
                {
                    peshoHealth -= goshoDamage;
                    if (peshoHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {roundCounter}th round.");
                        break;
                    }
                    Console.WriteLine($"Gosho used {goshoAttack} and reduced Pesho to {peshoHealth} health.");
                }
                if (roundCounter % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
            }
        }
    }
}
