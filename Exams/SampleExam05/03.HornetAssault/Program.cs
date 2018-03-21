using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehivesAndAmountOfBees = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();
            List<long> hornetsAndHornetsPower = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            long hornetsPower = hornetsAndHornetsPower.Sum();
            for (int i = 0; i < beehivesAndAmountOfBees.Count; i++)
            {
                if (hornetsPower > beehivesAndAmountOfBees[i])
                {
                    beehivesAndAmountOfBees.RemoveAt(i);
                    i--;
                }
                else if (hornetsPower <= beehivesAndAmountOfBees[i])
                {
                    beehivesAndAmountOfBees[i] = beehivesAndAmountOfBees[i] - hornetsPower;
                    if (beehivesAndAmountOfBees[i] <= 0)
                    {
                        beehivesAndAmountOfBees.RemoveAt(i);
                        i--;
                    }
                    if (hornetsAndHornetsPower.Count > 0)
                    {
                        hornetsAndHornetsPower.RemoveAt(0);
                        if (hornetsAndHornetsPower.Count <= 0)
                        {
                            break;
                        }
                    }
                    hornetsPower = hornetsAndHornetsPower.Sum();
                }
            }

            if (beehivesAndAmountOfBees.Count > 0)
            {
                Console.WriteLine(string.Join(" ", beehivesAndAmountOfBees));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornetsAndHornetsPower));
            }
        }
    }
}
