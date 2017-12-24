using System;
using System.Text;

namespace _08.Mines
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int startIndex = 0;
            int endIndex = 0;

            while ((startIndex = input.IndexOf("<", startIndex)) != -1 && (endIndex = input.IndexOf(">", startIndex)) != -1)
            {
                string chars = input.Substring(startIndex + 1, 2);

                int power = Math.Abs(chars[0] - chars[1]);

                int leftIndex = Math.Max(0, startIndex - power);
                int rightIndex = Math.Min(input.Length - 1, endIndex + power);

                StringBuilder result = new StringBuilder(input)

                for (int i = leftIndex; i <= rightIndex; i++)
                {
                    result[i] = '_';
                }
                input = result.ToString();

            }
            Console.WriteLine(input);
        }
    }
}
