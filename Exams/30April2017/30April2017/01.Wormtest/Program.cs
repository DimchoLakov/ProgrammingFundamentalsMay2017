using System;

namespace _01.Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            long wormLengthMeters = long.Parse(Console.ReadLine());
            double wormWidthCentimeters = double.Parse(Console.ReadLine());

            double wormLenthCentimeters = wormLengthMeters * 100.0;
            double remainder = wormLenthCentimeters % wormWidthCentimeters;
            if (double.IsNaN(remainder) || remainder == 0)
            {
                double product = wormWidthCentimeters * wormLenthCentimeters;
                Console.WriteLine($"{product:f2}");
            }
            else
            {
                double percentage = (wormLenthCentimeters / wormWidthCentimeters) * 100;
                Console.WriteLine($"{percentage:f2}%");
            }
        }
    }
}
