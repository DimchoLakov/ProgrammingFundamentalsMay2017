using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.WormWorldParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, long>> wormsData = new Dictionary<string, Dictionary<string, long>>();

            while (input != "quit")
            {
                string[] tokens = input.Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);
                string wormName = tokens[0];
                string teamName = tokens[1];
                long wormScore = long.Parse(tokens[2]);

                try
                {
                    var temp = wormsData.Values.Where(x => x.ContainsKey(wormName)).First().Count;
                }
                catch (Exception e)
                {
                    if (!wormsData.ContainsKey(teamName))
                    {
                        wormsData.Add(teamName, new Dictionary<string, long>());
                    }
                    if (!wormsData[teamName].ContainsKey(wormName))
                    {
                        wormsData[teamName].Add(wormName, wormScore);
                    }
                }
                input = Console.ReadLine();
            }
            int count = 1;
            foreach (var teamPair in wormsData.OrderByDescending(x => x.Value.Values.Sum()).ThenByDescending(x => x.Value.Values.Average()))
            {
                long sum = teamPair.Value.Values.Sum();
                Console.WriteLine($"{count}. Team: {teamPair.Key} - {sum}");
                foreach (var wormsPair in teamPair.Value.OrderByDescending(s => s.Value))
                {
                    Console.WriteLine($"###{wormsPair.Key} : {wormsPair.Value}");
                }
                count++;
            }
        }
    }
}
