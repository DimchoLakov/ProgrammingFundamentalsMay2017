using System;

namespace _01.Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                ulong bodyLength = ulong.Parse(Console.ReadLine());
                decimal bodyWidth = decimal.Parse(Console.ReadLine());
                ulong oneWingLength = ulong.Parse(Console.ReadLine());

                decimal totalYearsToReincarnate = (decimal)Math.Pow(bodyLength, 2) * (bodyWidth + 2 * oneWingLength);
                Console.WriteLine(totalYearsToReincarnate);
            }
        }
    }
}
