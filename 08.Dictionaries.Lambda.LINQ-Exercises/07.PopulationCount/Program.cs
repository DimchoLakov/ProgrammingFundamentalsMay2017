using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PopulationCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split('|');

            Dictionary<string, Dictionary<string, long>> countryPopulation = new Dictionary<string, Dictionary<string, long>>();

            while (input != "report")
            {
                string city = tokens[0];
                string country = tokens[1];
                long population = long.Parse(tokens[2]);

                if (!countryPopulation.ContainsKey(country))
                {
                    countryPopulation.Add(country, new Dictionary<string, long>());
                }

                if (!countryPopulation[country].ContainsKey(city))
                {
                    countryPopulation[country].Add(city, population);
                }


                input = Console.ReadLine();
                tokens = input.Split('|');
            }

            var sortedCountries = countryPopulation.OrderByDescending(x => x.Value.Values.Sum());

            foreach (KeyValuePair<string, Dictionary<string, long>> country in sortedCountries)
            {

                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");

                var sortedCities = country.Value.OrderByDescending(c => c.Value);

                foreach (var city in sortedCities)
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }

            }
        }
    }
}
