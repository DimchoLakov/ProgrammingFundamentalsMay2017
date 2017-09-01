using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Weather
{
    class City
    {
        public string Name { get; set; }
        public double Temperature { get; set; }
        public string Weather { get; set; }

        public static City Parse(string name, double temp, string weather)
        {
            return new City
            {
                Name = name,
                Temperature = temp,
                Weather = weather
            };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, City> forecast = new Dictionary<string, City>();

            string pattern = @"(?<town>[A-Z]{2})(?<temp>\d+\.\d+)(?<weath>[A-Za-z]+)(?=(\|))";

            Regex cityRegex = new Regex(pattern);

            while (input != "end")
            {
                if (cityRegex.IsMatch(input))
                {
                    string city = cityRegex.Match(input).Groups["town"].Value;
                    double temp = double.Parse(cityRegex.Match(input).Groups["temp"].Value);
                    string weather = cityRegex.Match(input).Groups["weath"].Value;

                    if (! forecast.ContainsKey(city))
                    {
                        forecast.Add(city, City.Parse(city, temp, weather));
                    }
                    else
                    {
                        if (forecast[city].Temperature != temp)
                        {
                            forecast[city].Temperature = temp;
                        }
                        if (forecast[city].Weather != weather)
                        {
                            forecast[city].Weather = weather;
                        }
                    }
                }
                
                input = Console.ReadLine();
            }

            foreach (var city in forecast.OrderBy(x => x.Value.Temperature))
            {
                Console.WriteLine($"{city.Key} => {city.Value.Temperature:f2} => {city.Value.Weather}");
            }
        }
    }
}
