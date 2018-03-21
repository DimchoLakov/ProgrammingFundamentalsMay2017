using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[^0-9]+\d{1,2}";
            string digitsPattern = @"\d+";
            string nonDigitsPattern = @"\D+";

            string input = Console.ReadLine();

            Regex regexRage = new Regex(pattern);

            MatchCollection matches = regexRage.Matches(input);

            StringBuilder rageMessage = new StringBuilder();

            foreach (Match match in matches)
            {
                int repeatCount = int.Parse(Regex.Match(match.Value, digitsPattern).ToString());
                string repeatString = Regex.Match(match.Value, nonDigitsPattern).ToString();

                for (int i = 0; i < repeatCount; i++)
                {
                    rageMessage.Append(repeatString);
                }
                
            }

            int uniqueSymbolsCount = rageMessage.ToString().ToUpper().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {uniqueSymbolsCount}");

            Console.WriteLine(rageMessage.ToString().ToUpper());
        }
    }
}
