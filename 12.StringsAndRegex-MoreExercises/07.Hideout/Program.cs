using System;
using System.Text.RegularExpressions;

namespace _07.Hideout
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (true)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                string searchedChar = tokens[0];
                int minCount = int.Parse(tokens[1]);
                
                string escapedPattern = $"{Regex.Escape(searchedChar)}{{{minCount},}}";

                Match match = Regex.Match(input, escapedPattern);
                if (match.Success)
                {
                    int index = input.IndexOf(match.Value);
                    int length = match.Value.Length;
                    Console.WriteLine($"Hideout found at index {index} and it is with size {length}!");
                    return;
                }
            }
        }
    }
}
