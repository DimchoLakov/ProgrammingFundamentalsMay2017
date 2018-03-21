using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.HornetArmada
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> legionAndActivity = new Dictionary<string, int>();
            Dictionary<string, Dictionary<string, long>> soldiers = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(new[] { '=', '-', '>', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int activity = int.Parse(tokens[0]);
                string legionName = tokens[1];
                string soldierType = tokens[2];
                long soldierCount = long.Parse(tokens[3]);

                if (!legionAndActivity.ContainsKey(legionName))
                {
                    legionAndActivity.Add(legionName, activity);
                    soldiers.Add(legionName, new Dictionary<string, long>());
                }

                if (!soldiers[legionName].ContainsKey(soldierType))
                {
                    soldiers[legionName].Add(soldierType, 0);
                }

                if (legionAndActivity[legionName] < activity)
                {
                    legionAndActivity[legionName] = activity;
                }

                soldiers[legionName][soldierType] += soldierCount;
            }

            string finalInput = Console.ReadLine();
            string[] finalTokens = finalInput.Split('\\');

            if (finalTokens.Length > 1)
            {
                int searchedActivity = int.Parse(finalTokens[0]);
                string searchedSoldierType = finalTokens[1];

                foreach (var soldierPair in soldiers.Where(x => x.Value.ContainsKey(searchedSoldierType))
                    .OrderByDescending(x => x.Value[searchedSoldierType]))
                {
                    string legionName = soldierPair.Key;
                    long soldierSum = soldiers[soldierPair.Key][searchedSoldierType];
                    if (legionAndActivity[legionName] < searchedActivity)
                    {
                        Console.WriteLine($"{legionName} -> {soldierSum}");
                    }
                }
            }
            else
            {
                string searchedSoldierType = finalTokens[0];

                foreach (KeyValuePair<string, int> legion in legionAndActivity.OrderByDescending(a => a.Value))
                {
                    string legionName = legion.Key;
                    int lastActivity = legion.Value;
                    if (soldiers[legionName].ContainsKey(searchedSoldierType))
                    {
                        Console.WriteLine($"{lastActivity} : {legionName}");
                    }
                }
            }
        }
    }
}
