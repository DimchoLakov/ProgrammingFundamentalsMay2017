using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.WormIpsum
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordPattern = @"\w+";

            string input = Console.ReadLine();

            while (input != "Worm Ipsum")
            {
                string[] tokens = input.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                string tempSentence = tokens[0];

                if (tokens.Length == 1 && char.IsUpper(tempSentence[0]))
                {
                    string[] words = tokens[0].Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);

                    List<string> result = new List<string>();
                    foreach (string text in words)
                    {
                        Regex word = new Regex(wordPattern);
                        if (word.IsMatch(text))
                        {
                            result.Add(ProcessWord(text));
                        }

                    }
                    Console.WriteLine(string.Join(" ", result) + ".");
                }

                input = Console.ReadLine();
            }
        }

        static string ProcessWord(string wordMatchValue)
        {
            Dictionary<char, int> charDict = new Dictionary<char, int>();
            bool isRepeating = false;
            for (int i = 0; i < wordMatchValue.Length; i++)
            {
                if (!charDict.ContainsKey(wordMatchValue[i]))
                {
                    charDict.Add(wordMatchValue[i], 1);
                }
                else
                {
                    charDict[wordMatchValue[i]]++;
                    isRepeating = true;
                }
            }
            if (isRepeating)
            {
                char charToRepeat = charDict.OrderByDescending(c => c.Value).First().Key;
                var arr = wordMatchValue.ToCharArray();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (char.IsLetter(arr[i]))
                    {
                        arr[i] = charToRepeat;
                    }
                }
                return new string(arr);
            }

            return wordMatchValue;
        }
    }
}
