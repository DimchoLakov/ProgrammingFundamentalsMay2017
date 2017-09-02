using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06.ValidUsernames
{
    class User
    {
        public string Name { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split(new char[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"\b([a-zA-Z]{1}[A-Za-z_0-9]{2,24})\b";

            Regex userRegex = new Regex(pattern);

            List<string> result = new List<string>();

            foreach (string user in tokens)
            {
                if (userRegex.IsMatch(user))
                {
                    result.Add(user);
                }
            }

            int maxSum = 0;

            string firstUser = string.Empty;
            string secondUser = string.Empty;

            for (int i = 1; i < result.Count; i++)
            {
                int currentSum = result[i - 1].Length + result[i].Length;

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    firstUser = result[i - 1];
                    secondUser = result[i];
                }
            }

            Console.WriteLine(firstUser);
            Console.WriteLine(secondUser);
        }
    }
}
