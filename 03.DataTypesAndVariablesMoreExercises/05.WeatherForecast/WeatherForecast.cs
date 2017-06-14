using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.WeatherForecast
{
    class WeatherForecast
    {
        static void Main(string[] args)
        {
            long number;
            string input = Console.ReadLine();
            if (long.TryParse(input, out number))
            {
                if ((number >= sbyte.MinValue && number <= sbyte.MaxValue) || (number >= byte.MinValue && number <= byte.MaxValue))
                {
                    Console.WriteLine("Sunny");
                }
                else if (number >= int.MinValue && number <= int.MaxValue)
                {
                    Console.WriteLine("Cloudy");
                }
                else if (number >= long.MinValue && number <= long.MaxValue)
                {
                    Console.WriteLine("Windy");
                }
            }
            else
            {
                Console.WriteLine("Rainy");
            }
        }
    }
}
