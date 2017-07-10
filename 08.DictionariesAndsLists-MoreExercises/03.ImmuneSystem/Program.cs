using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ImmuneSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int immuneSystemHealth = int.Parse(Console.ReadLine());
            int remainingHealth = immuneSystemHealth;
            string virusName = Console.ReadLine();

            Dictionary<string, int> virusesDictionary = new Dictionary<string, int>();

            while (virusName != "end")
            {
                bool hasDefeated = false;
                char[] letters = virusName.ToCharArray();
                int sum = 0;

                for (int i = 0; i < letters.Length; i++)
                {
                    sum += letters[i];
                }

                int virusStrength = sum / 3;

                int timeToDefeatVirus = virusStrength * letters.Length;

                int fasterFighting = (virusStrength * letters.Length) / 3;

                if (!virusesDictionary.ContainsKey(virusName))
                {
                    virusesDictionary.Add(virusName, 1);
                }
                else
                {
                    virusesDictionary[virusName] += 1;
                }

                if (virusesDictionary[virusName] == 2)
                {
                    timeToDefeatVirus = fasterFighting;
                }

                int minutesToDefeatVirus = timeToDefeatVirus / 60;
                int secondsToDefeatVirus = timeToDefeatVirus % 60;

                Console.WriteLine($"Virus {virusName}: {virusStrength} => {timeToDefeatVirus} seconds");

                if (timeToDefeatVirus < remainingHealth)
                {
                    Console.WriteLine($"{virusName} defeated in {minutesToDefeatVirus}m {secondsToDefeatVirus}s.");
                    hasDefeated = true;
                    remainingHealth -= timeToDefeatVirus;
                    Console.WriteLine($"Remaining health: {remainingHealth}");
                }
                else
                {
                    Console.WriteLine("Ïmmune System Defeated.");
                    return;
                }

                if (hasDefeated)
                {
                    if ((int)(remainingHealth * 0.2) + remainingHealth > immuneSystemHealth)
                    {
                        remainingHealth = immuneSystemHealth;
                    }
                    else
                    {
                        remainingHealth += (int)(remainingHealth * 0.2);
                    }
                }



                virusName = Console.ReadLine();
            }


            Console.WriteLine($"Final Health: {remainingHealth}");

        }
    }
}
