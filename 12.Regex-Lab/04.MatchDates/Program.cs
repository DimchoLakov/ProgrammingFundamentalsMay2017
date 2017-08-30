using System;
using System.Text.RegularExpressions;

namespace _04.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string datesPattern = @"\b(?<days>\d{2})(?<deli>[\/\-\.])(?<month>[A-Z][a-z]{2})\k<deli>(?<year>\d{4})\b";

            Regex dateRegex = new Regex(datesPattern);

            MatchCollection dateMatches = dateRegex.Matches(input);

            foreach (Match date in dateMatches)
            {
                Console.WriteLine($"Day: {date.Groups["days"].Value}, Month: {date.Groups["month"].Value}, Year: {date.Groups["year"].Value}");
            }
        }
    }
}
