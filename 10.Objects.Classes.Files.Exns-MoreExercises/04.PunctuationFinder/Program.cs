using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _04.PunctuationFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines(@"C:\text-test\sample_text.txt");
            char[] punctuationSymbols = new[] {':', ',', '.', '!', '?'};
            List<char> result = new List<char>();

            foreach (var line in text)
            {
                foreach (var c in line)
                {
                    if (punctuationSymbols.Contains(c))
                    {
                        result.Add(c);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
