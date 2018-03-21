using System;

namespace _01.SplinterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripDistance = double.Parse(Console.ReadLine());
            double tankCapacity = double.Parse(Console.ReadLine());
            double milesInHeavyWinds = double.Parse(Console.ReadLine());

            double milesInNonHeavyWinds = tripDistance - milesInHeavyWinds;
            double fuelNonHeavyWinds = milesInNonHeavyWinds * 25d;
            double fuelInHeavyWinds = milesInHeavyWinds * (25 * 1.5);
            double totalFuelConsumption = fuelInHeavyWinds + fuelNonHeavyWinds;
            totalFuelConsumption = totalFuelConsumption + totalFuelConsumption * 0.05;
            double diff = Math.Abs(totalFuelConsumption - tankCapacity);

            Console.WriteLine($"Fuel needed: {totalFuelConsumption:f2}L");
            if (totalFuelConsumption > tankCapacity)
            {
                Console.WriteLine($"We need {diff:f2}L more fuel.");
            }
            else if (totalFuelConsumption <= tankCapacity)
            {
                Console.WriteLine($"Enough with {diff:f2}L to spare!");
            }
        }
    }
}
