using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.MorseCodeUpgraded
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] message = Console.ReadLine().Split(new char[] {'|'}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            long sum = 0L;
            string result = string.Empty;
            foreach (string code in message)
            {
                var zeroes = code.Where(a => a == char.Parse("0")).Count();
                int zeroesSum = zeroes * 3;
                var ones = code.Where(a => a == char.Parse("1")).Count();
                int onesSum = ones * 5;
                sum = zeroesSum + onesSum;
                int consecutiveDigitsSum = GetConsecutiveDigitsSum(code);
                if (consecutiveDigitsSum>= 1)
                {
                    sum += consecutiveDigitsSum;
                }
                result += (char)sum;
            }
            Console.WriteLine(result);
        }

        static int GetConsecutiveDigitsSum(string code)
        {
            string pattern = @"1{2,}|0{2,}";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(code);
            int count = 0;
            foreach (Match match in matches)
            {
                count += match.Value.Length;
            }
            return count;
        }
    }
}
