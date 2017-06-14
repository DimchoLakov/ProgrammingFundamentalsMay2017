using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PriceChangeAlert
{
    class PriceChangeAlert
    {
        static void Main(string[] args)
        {
            int numberOfPrices = int.Parse(Console.ReadLine());
            double significanceThreshold = double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPrices - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double diff = CalculateDiff(lastPrice, currentPrice);
                bool isSignificantDifference = GetDifference(diff, significanceThreshold);

                string update = GetUpdate(currentPrice, lastPrice, diff, isSignificantDifference);
                Console.WriteLine(update);

                lastPrice = currentPrice;
            }
        }

        static string GetUpdate(double currentPrice, double lastPrice, double diff, bool diffOrNot)
        {
            string change = "";
            if (diff == 0)
            {
                change = string.Format($"NO CHANGE: {currentPrice}");
            }
            else if (!diffOrNot)
            {
                change = string.Format($"MINOR CHANGE: {lastPrice} to {currentPrice} ({diff * 100:F2}%)");
            }
            else if (diffOrNot && (diff > 0))
            {
                change = string.Format($"PRICE UP: {lastPrice} to {currentPrice} ({diff * 100:F2}%)");
            }
            else if (diffOrNot && (diff < 0))
            {
                change = string.Format($"PRICE DOWN: {lastPrice} to {currentPrice} ({diff * 100:F2}%)");
            }
            return change;
        }

        private static bool GetDifference(double diff, double significantThreshold)
        {
            if (Math.Abs(diff) >= significantThreshold)
            {
                return true;
            }
            return false;
        }

        private static double CalculateDiff(double lastPrice, double currentPrice)
        {
            double percentage = (currentPrice - lastPrice) / lastPrice;
            return percentage;
        }
    }
}
