using System;

namespace _01.CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            long daysMarathon = long.Parse(Console.ReadLine());
            long runnersCount = long.Parse(Console.ReadLine());
            long lapsAverage = long.Parse(Console.ReadLine());
            long trackLength = long.Parse(Console.ReadLine());
            long trackCapacity = long.Parse(Console.ReadLine());
            decimal moneyPerKilometer = decimal.Parse(Console.ReadLine());

            var maxRunners = trackCapacity * daysMarathon;

            if (runnersCount > maxRunners)
            {
                runnersCount = maxRunners;
            }

            var totalMeters = runnersCount * lapsAverage * trackLength;
            var totalKilometers = totalMeters / 1000;
            var totalMoney = totalKilometers * moneyPerKilometer;
            Console.WriteLine($"Money raised: {totalMoney:f2}");
        }
    }
}
