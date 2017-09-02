using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyString = Console.ReadLine();
            string text = Console.ReadLine();

            string startKeyString = GetStartKeyString(keyString);
            string endKeySTring = GetEndKeyString(keyString);

            string pattern = $"{startKeyString}(?<data>(.*?)){endKeySTring}";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            StringBuilder sb = new StringBuilder();

            foreach (Match match in matches)
            {
                string result = match.Groups["data"].Value;
                sb.Append(result);
            }
            Console.WriteLine(sb.Length == 0 ? $"Empty result" : sb.ToString());
        }

        private static string GetEndKeyString(string keyString)
        {
            char[] symbolArr = new[] {'|', '<', '\\'};
            int index = keyString.LastIndexOfAny(symbolArr);
            
            string result = keyString.Substring(index + 1,keyString.Length - index - 1);
            return result;
        }

        private static string GetStartKeyString(string keyString)
        {
            char[] symbolArr = new[] { '|', '<', '\\' };
            int index = keyString.IndexOfAny(symbolArr);

            string result = keyString.Substring(0, index);
            return result;
        }
    }
}
