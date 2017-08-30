using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.MatchHexadecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string hexPattern = @"\b(0x)*[A-F0-9]+\b";

            Regex hexRegex = new Regex(hexPattern);

            MatchCollection hexMatches = hexRegex.Matches(input);

            string[] matches = hexMatches.Cast<Match>().Select(h => h.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(" ", matches));
        }
    }
}
