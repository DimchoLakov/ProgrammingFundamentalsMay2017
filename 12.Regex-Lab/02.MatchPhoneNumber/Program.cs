using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string phonePattern = @"\+359( |\-)2\1\d{3}\1\d{4}\b";

            Regex phoneRegex = new Regex(phonePattern);

            MatchCollection phoneMatches = phoneRegex.Matches(input);

            string[] matches = phoneMatches.Cast<Match>().Select(p => p.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
