using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01.Snowballs
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<BigInteger, List<long>> snowballsDict = new Dictionary<BigInteger, List<long>>();

            for (int i = 0; i < n; i++)
            {
                long snowballSnow = long.Parse(Console.ReadLine());
                long snowballTime = long.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                snowballsDict.Add(snowballValue, new List<long>(){snowballSnow, snowballTime, snowballQuality});
            }

            var result = snowballsDict.OrderByDescending(s => s.Key).First();
            long resultSnow = result.Value[0];
            long resultTime = result.Value[1];
            long resultQuality = result.Value[2];
            BigInteger resultValue = result.Key;
            
            Console.WriteLine($"{resultSnow} : {resultTime} = {resultValue} ({resultQuality})");
        }
    }
}
