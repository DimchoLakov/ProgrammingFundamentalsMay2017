using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddOccurrences
{
    class OddOccurrences
    {
        static void Main(string[] args)
        {
            List<string> wordsList = Console.ReadLine().ToLower().Split().ToList();
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var word in wordsList)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word] += 1;
                }
                else
                {
                    dict[word] = 1;
                }
            }
            List<string> result = new List<string>();
            foreach (var word in dict)
            {
                if (word.Value % 2 == 1)
                {
                    result.Add(word.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
