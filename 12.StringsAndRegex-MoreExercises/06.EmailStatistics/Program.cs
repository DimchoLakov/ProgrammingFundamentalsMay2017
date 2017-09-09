using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06.EmailStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> data = new Dictionary<string, HashSet<string>>();

            string pattern = @"^[a-zA-Z]{5,}\@{1}[a-z]{3,}((\.com)|(\.bg)|(\.org))$";
            Regex regex = new Regex(pattern);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (regex.IsMatch(input))
                {
                    string[] tokens = input.Split('@');
                    string username = tokens[0];
                    string domain = tokens[1];

                    if (!data.ContainsKey(domain))
                    {
                        data.Add(domain, new HashSet<string>());
                    }
                    data[domain].Add(username);
                }
            }

            foreach (KeyValuePair<string, HashSet<string>> emailPair in data.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{emailPair.Key}:");
                foreach (string user in emailPair.Value)
                {
                    Console.WriteLine($"### {user}");
                }
            }
        }
    }
}
