using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.SpyGram
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"TO\: (?<sender>[A-Z]+)\; MESSAGE\: .+\;";

            Dictionary<string, List<string>> messages = new Dictionary<string, List<string>>();

            string privateKey = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "END")
            {
                Regex regex = new Regex(pattern);

                Match match = regex.Match(input);
                string matchValue = match.Value;
                string result = ModifyMatch(matchValue, privateKey);
                if (!string.IsNullOrEmpty(result))
                {
                    string sender = match.Groups["sender"].ToString();
                    if (!messages.ContainsKey(sender))
                    {
                        messages.Add(sender, new List<string>());
                    }
                    messages[sender].Add(result);
                }

                input = Console.ReadLine();
            }
            foreach (var message in messages.OrderBy(x => x.Key))
            {
                foreach (string mess in message.Value)
                {
                    Console.WriteLine(mess);
                }
            }
        }
        static string ModifyMatch(string match, string privateKey)
        {
            List<int> shiftNumbers = new List<int>();
            char[] matchChars = match.ToCharArray();
            foreach (char num in privateKey)
            {
                shiftNumbers.Add(num - '0');
            }

            int shiftIndex = 0;

            for (int i = 0; i < matchChars.Length; i++)
            {
                matchChars[i] = (char)(matchChars[i] + int.Parse(shiftNumbers[shiftIndex].ToString()));
                if (shiftIndex == shiftNumbers.Count - 1)
                {
                    shiftIndex = 0;
                }
                else
                {
                    shiftIndex++;
                }
            }
            string result = new string(matchChars);

            return result;
        }
    }
}
