using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int participantsNumber = int.Parse(Console.ReadLine());

            double technical = 0d;
            double theoretical = 0d;
            double practical = 0d;

            for (int i = 0; i < participantsNumber; i++)
            {
                int distanceInMiles = int.Parse(Console.ReadLine());
                double cargoInTons = double.Parse(Console.ReadLine());
                string team = Console.ReadLine();

                int distanceInMeters = distanceInMiles * 1600;
                double fuelPrice = distanceInMeters * 0.7 * 2.5;
                double cargoIncome = cargoInTons * 1000 * 1.5;
                double totalMoney = cargoIncome - fuelPrice;

                if (team == "Technical")
                {
                    technical += totalMoney;
                }
                else if (team == "Practical")
                {
                    practical += totalMoney;
                }
                else if (team == "Theoretical")
                {
                    theoretical += totalMoney;
                }
            }
            Dictionary<string, double> teamsDict = new Dictionary<string, double>();
            teamsDict.Add("Technical", technical);
            teamsDict.Add("Practical", practical);
            teamsDict.Add("Theoretical", theoretical);
            int count = 1;
            foreach (var teamPair in teamsDict.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"The {teamPair.Key} Trainers win with ${teamPair.Value:f3}.");
                if (count == 1)
                {
                    break;
                }
            }
        }
    }
}
