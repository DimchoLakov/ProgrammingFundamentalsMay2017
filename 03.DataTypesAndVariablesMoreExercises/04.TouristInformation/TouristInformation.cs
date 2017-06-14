using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TouristInformation
{
    class TouristInformation
    {
        static void Main(string[] args)
        {
            string imperialUnit = Console.ReadLine();
            double valueToConvert = double.Parse(Console.ReadLine());
            double value = 0d;
            string metricUnit = null;
            switch (imperialUnit)
            {
                case "miles":
                    value = 1.6;
                    metricUnit = "kilometers";
                    break;
                case "inches":
                    value = 2.54;
                    metricUnit = "centimeters";
                    break;
                case "feet":
                    value = 30d;
                    metricUnit = "centimeters";
                    break;
                case "yards":
                    value = 0.91;
                    metricUnit = "meters";
                    break;
                case "gallons":
                    value = 3.8;
                    metricUnit = "liters";
                    break;
                default:
                    break;
            }
            double result = valueToConvert * value;
            Console.WriteLine($"{valueToConvert} {imperialUnit} = {result:f2} {metricUnit}");
        }
    }
}
