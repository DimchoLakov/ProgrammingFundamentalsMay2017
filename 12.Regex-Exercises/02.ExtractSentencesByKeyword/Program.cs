using System;
using System.Collections.Generic;

namespace _02.ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyword = Console.ReadLine();
            string text = Console.ReadLine();
            List<string> result = new List<string>();
            char[] delimiters =
            {
                ' ', ',', ':', ';', '\'', '\"', '-', '_', '+', '=', '@', '#', '$', '%', '^', '&', '*', '(', ')', '[',
                ']', '{', '}', '<', '>', '|', '\\', '/'
            };

            string[] tokens = text.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string sentence in tokens)
            {
                string[] words = sentence.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words)
                {
                    if (word == keyword)
                    {
                        result.Add(sentence);
                        break;
                    }
                }
            }

            foreach (string sentence in result)
            {
                Console.WriteLine(sentence.Trim());
            }
        }
    }
}
