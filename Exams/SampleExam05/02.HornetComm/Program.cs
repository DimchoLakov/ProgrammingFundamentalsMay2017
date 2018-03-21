using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KeyValuePair<string, string>> broadcastList = new List<KeyValuePair<string, string>>();
            List<KeyValuePair<string, string>> messageList = new List<KeyValuePair<string, string>>();
            
            string input = Console.ReadLine();

            while (input != "Hornet is Green")
            {
                string[] tokens = input.Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length <= 1)
                {
                    input = Console.ReadLine();
                    continue;
                }
                string left = tokens[0];
                string right = tokens[1];

                if (left.All(char.IsDigit) && right.All(char.IsLetterOrDigit))
                {
                    string reversedCode = ReverseCode(left);
                    messageList.Add(new KeyValuePair<string, string>(reversedCode, right));
                }
                else if (!left.All(char.IsDigit) && right.All(char.IsLetterOrDigit))
                {
                    string frequencyResult = SwapLowerWithUpperLetters(right);
                    broadcastList.Add(new KeyValuePair<string, string>(frequencyResult, left));
                }
                
                input = Console.ReadLine();
            }

            Console.WriteLine($"Broadcasts:");

            foreach (KeyValuePair<string, string> broadcastPair in broadcastList)
            {
                Console.WriteLine($"{broadcastPair.Key} -> {broadcastPair.Value}");
            }
            if (broadcastList.Count == 0)
            {
                Console.WriteLine($"None");
            }

            Console.WriteLine($"Messages:");

            foreach (KeyValuePair<string, string> messagePair in messageList)
            {
                Console.WriteLine($"{messagePair.Key} -> {messagePair.Value}");
            }
            if (messageList.Count == 0)
            {
                Console.WriteLine($"None");
            }
        }

        static string SwapLowerWithUpperLetters(string frequency)
        {
            char[] arr = frequency.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsUpper(arr[i]))
                {
                    arr[i] = (char)(arr[i] + 32);
                }
                else if (char.IsLower(arr[i]))
                {
                    arr[i] = (char)(arr[i] - 32);
                }
            }
            string result = new string(arr);

            return result;
        }

        static string ReverseCode(string recipientCode)
        {
            char[] reversed = recipientCode.ToCharArray().Reverse().ToArray();
            string result = new string(reversed);
            return result;
        }
    }
}
