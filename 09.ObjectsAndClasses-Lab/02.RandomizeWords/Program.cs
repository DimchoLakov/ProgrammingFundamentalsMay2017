using System;
namespace _02.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            Random rnd = new Random();

            for (int pos1 = 0; pos1 < words.Length; pos1++)
            {
                int pos2 = rnd.Next(0, words.Length - 1);

                string temp = words[pos1];
                words[pos1] = words[pos2];
                words[pos2] = temp;
            }
            Console.WriteLine(string.Join($"{Environment.NewLine}", words));
        }
    }
}
