using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.StringConcatenation
{
    class StringConcatenation
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string evenOrOdd = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string words = null;
            for (int i = 1; i <= n; i++)
            {
                string str = Console.ReadLine();
                if (evenOrOdd == "odd")
                {
                    if (i % 2 == 1)
                    {
                        words += str + delimiter;
                    }
                }
                else if (evenOrOdd == "even")
                {
                    if (i % 2 == 0)
                    {
                        words += str + delimiter;
                    }                    
                }
            }
            Console.WriteLine(words.Remove(words.Length - 1));
        }
    }
}
