using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.CodePhoenixOscarRomeoNovember
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();

            HashSet<string> creaturesList = new HashSet<string>();
            HashSet<string> matesList = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "Blaze it!")
            {
                string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string creature = tokens[0];
                string mate = tokens[1];
                creaturesList.Add(creature);
                matesList.Add(mate);

                AddCreaturesAndSquadMates(data, creature, mate);

                input = Console.ReadLine();
            }

            FilterData(data, creaturesList, matesList);

            PrintResult(data);
        }

        private static void FilterData(Dictionary<string, List<string>> data, HashSet<string> creaturesList, HashSet<string> matesList)
        {
            foreach (string creatureName in creaturesList)
            {
                foreach (string mateName in matesList)
                {
                    if (data.ContainsKey(mateName) && data[mateName].Contains(creatureName)
                        && data.ContainsKey(creatureName) && data[creatureName].Contains(mateName))
                    {
                        data[creatureName].Remove(mateName);
                        data[mateName].Remove(creatureName);
                    }
                }
            }
        }

        static void PrintResult(Dictionary<string, List<string>> data)
        {
            foreach (KeyValuePair<string, List<string>> creatureMates in data.OrderByDescending(x => x.Value.Count))
            {
                string monster = creatureMates.Key;
                int matesCount = creatureMates.Value.Count;
                Console.WriteLine($"{monster} : {matesCount}");
            }
        }

        static void AddCreaturesAndSquadMates(Dictionary<string, List<string>> data, string creature, string mate)
        {
            if (!data.ContainsKey(creature))
            {
                data.Add(creature, new List<string>());
                if (creature != mate)
                {
                    data[creature].Add(mate);
                }
            }
            else
            {
                if (!data[creature].Contains(mate) && creature != mate)
                {
                    data[creature].Add(mate);
                }
            }
        }
    }
}
