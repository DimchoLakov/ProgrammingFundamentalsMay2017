using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            Regex nameRegex = new Regex(namePattern);

            string input = Console.ReadLine();

            MatchCollection nameMatches = nameRegex.Matches(input);

            string[] matches = nameMatches.Cast<Match>().Select(m => m.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(" ", matches));
        }
    }
}
