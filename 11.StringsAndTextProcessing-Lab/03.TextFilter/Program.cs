using System;

namespace _03.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                .Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

            string input = Console.ReadLine();
            
            foreach (string bannedWord in bannedWords)
            {
                input = input.Replace($"{bannedWord}", new string('*', bannedWord.Length));
            }

            Console.WriteLine(input);
        }
    }
}
