using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> palindromes = new SortedSet<string>();

            char[] delimiters = new char[] {',', '.', '!', '?', ' '};

            string[] words = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            
            foreach (string word in words)
            {
                if (isPalindrome(word))
                {
                    palindromes.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ", palindromes));
        }

        static bool isPalindrome(string word)
        {
            string original = word;
            string reversed = new string(original.Reverse().ToArray());
            bool isPalindrome = original == reversed;
            return isPalindrome;
        }
    }
}
