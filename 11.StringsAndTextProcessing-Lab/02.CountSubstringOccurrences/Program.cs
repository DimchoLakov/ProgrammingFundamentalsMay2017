using System;

namespace _02.CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            string searchStr = Console.ReadLine().ToLower();

            int index = input.IndexOf(searchStr);
            int occurrences = 0;

            while (index != -1)
            {
                index = input.IndexOf(searchStr, index + 1);

                occurrences++;
            }
            Console.WriteLine(occurrences);
        }
    }
}
