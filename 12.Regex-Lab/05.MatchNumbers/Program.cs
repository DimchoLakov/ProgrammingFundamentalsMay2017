using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string numberPattern = @"(^|(?<=\s))\-?\d+(\.\d+)*($|(?=\s))";

            Regex numberRegex = new Regex(numberPattern);

            MatchCollection numberMatches = numberRegex.Matches(input);

            string[] matches = numberMatches.Cast<Match>().Select(n => n.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(" ", matches));
        }
    }
}
