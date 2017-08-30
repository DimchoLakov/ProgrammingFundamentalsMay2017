using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06.ReplaceATag
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string tagPattern = @"<a.*?href.*?=(.*?)>(.*?)<\/a>";
            string replacePattern = @"[URL href=$1]$2[/URL]";

            while (input != "end")
            {
                string result = Regex.Replace(input, tagPattern, replacePattern);

                Console.WriteLine(result);

                input = Console.ReadLine();
            }
        }
    }
}
