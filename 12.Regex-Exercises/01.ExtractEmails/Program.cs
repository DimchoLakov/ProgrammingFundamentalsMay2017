using System;
using System.Text.RegularExpressions;

namespace _01.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string emailPattern = @"(?<=\s)([a-z]+|\d+)(\d+|\w+|\.+|-+)([a-z]+|\d+)\@[a-z\-]+\.[a-z]+(\.[a-z]+)*";

            Regex emailRegex = new Regex(emailPattern);

            MatchCollection emailMatches = emailRegex.Matches(input);

            foreach (Match email in emailMatches)
            {
                Console.WriteLine(email.Value);
            }
        }
    }
}
