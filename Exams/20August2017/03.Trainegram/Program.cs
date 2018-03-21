using System;
using System.Text.RegularExpressions;

namespace _03.Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            string locoPattern = @"(?<loc>^\<\[[^a-zA-Z0-9]*?\]\.)(?<wag>\.\[[A-Za-z0-9]*\]\.)*$";

            string input = Console.ReadLine();

            while (input != "Traincode!")
            {
                Regex locoRegex = new Regex(locoPattern);
                MatchCollection locoMatches = locoRegex.Matches(input);

                foreach (Match locoMatch in locoMatches)
                {
                    Console.WriteLine(locoMatch);
                }
                
                input = Console.ReadLine();
            }

        }
    }
}
