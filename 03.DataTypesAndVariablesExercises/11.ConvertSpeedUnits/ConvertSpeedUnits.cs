using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            string time = $"{hours}:{minutes}:{seconds}";

            float miles = (distanceInMeters / 1000f) / 1.609f;
            float metersPerSecond = (float)(distanceInMeters / TimeSpan.Parse(time).TotalSeconds);
            float kilometerPerHour = (float)((distanceInMeters / 1000f) / TimeSpan.Parse(time).TotalHours);
            float milesPerHour = (float)(miles / TimeSpan.Parse(time).TotalHours);

            Console.WriteLine($"{metersPerSecond}");
            Console.WriteLine($"{kilometerPerHour}");
            Console.WriteLine($"{milesPerHour}");
        }
    }
}
