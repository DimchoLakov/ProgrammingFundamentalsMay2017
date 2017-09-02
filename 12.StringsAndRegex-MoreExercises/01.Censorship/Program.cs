using System;

namespace _01.Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            string replaceWord = Console.ReadLine();
            string sentence = Console.ReadLine();

            sentence = sentence.Replace(replaceWord, new string('*', replaceWord.Length));
            Console.WriteLine(sentence);
        }
    }
}
