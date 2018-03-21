using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _04.NSA
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> nsa = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "quit")
            {
                string[] tokens = input.Split(new string[] {$" -> "}, StringSplitOptions.RemoveEmptyEntries);

                string country = tokens[0];
                string spy = tokens[1];
                int daysInService = int.Parse(tokens[2]);

                if (! nsa.ContainsKey(country))
                {
                    nsa.Add(country, new Dictionary<string, int>());
                }
                if (! nsa[country].ContainsKey(spy))
                {
                    nsa[country].Add(spy, daysInService);
                }
                else
                {
                    nsa[country][spy] = daysInService;
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, int>> countrySpyPair in nsa.OrderByDescending(x => x.Value.Values.Count))
            {
                Console.WriteLine($"Country: {countrySpyPair.Key}");
                foreach (KeyValuePair<string, int> spyDaysPair in countrySpyPair.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"**{spyDaysPair.Key} : {spyDaysPair.Value}");
                }
            }
        }
    }
}
