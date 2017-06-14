using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> lowercaseWords = new List<string>();
            List<string> uppercaseWords = new List<string>();
            List<string> allOther = new List<string>();

            for (int index = 0; index < text.Count; index++)
            {
                if (text[index].All(char.IsLower))
                {
                    lowercaseWords.Add(text[index]);
                }
                else if (text[index].All(char.IsUpper))
                {
                    uppercaseWords.Add(text[index]);
                }
                else
                {
                    allOther.Add(text[index]);
                }
            }
            Console.WriteLine("Lower-case: " + string.Join(", ", lowercaseWords));
            Console.WriteLine("Mixed-case: " + string.Join(", ", allOther));
            Console.WriteLine("Upper-case: " + string.Join(", ", uppercaseWords));
        }
    }
}
