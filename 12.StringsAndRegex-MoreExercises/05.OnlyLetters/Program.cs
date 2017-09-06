using System;
using System.Text.RegularExpressions;

namespace _05.OnlyLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"\d+");
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                int index = input.IndexOf(match.Value) + match.Value.Length;
                try
                {
                    input = input.Replace(match.Value, input[index].ToString());
                }
                catch (Exception e)
                {
                    
                }
            }

            Console.WriteLine(input);
        }
    }
}
