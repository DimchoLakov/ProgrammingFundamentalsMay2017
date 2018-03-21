using System;

namespace _01.HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double distance = wingFlaps / 1000 * distanceInMeters;
            int seconds = wingFlaps / 100;
            double enduranceSeconds = (wingFlaps / endurance) * 5;
            double totalTime = seconds + enduranceSeconds;

            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{totalTime} s.");
        }
    }
}
