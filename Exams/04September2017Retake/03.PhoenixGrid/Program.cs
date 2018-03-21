using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.PhoenixGrid
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([^\s_]{3})(\.[^\s_]{3})*";

            string input = Console.ReadLine();

            while (input != "ReadMe")
            {
                Regex regex = new Regex(pattern);

                Match match = regex.Match(input.ToLower());
                if (match.Success && IsPalindrome(match.ToString()))
                {
                    Console.WriteLine($"YES");
                }
                else
                {
                    Console.WriteLine($"NO");
                }

                input = Console.ReadLine();
            }

        }

        static bool IsPalindrome(string input)
        {
            var reversed = new string(input.Reverse().ToArray());
            var palindrom = input == reversed;
            return palindrom;
        }
    }
}
