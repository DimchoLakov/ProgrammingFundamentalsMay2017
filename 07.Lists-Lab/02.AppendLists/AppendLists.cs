using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            List<string> results = new List<string>();
            string[] input = Console.ReadLine().Split('|').ToArray();
            
            for (int index = input.Length - 1; index >= 0; index--)
            {
                string[] tokens = input[index].Split(' ').ToArray();
                for (int i = 0; i < tokens.Length; i++)
                {
                    if (tokens[i] != "")
                    {
                        results.Add(tokens[i]);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", results));
        }
    }
}
