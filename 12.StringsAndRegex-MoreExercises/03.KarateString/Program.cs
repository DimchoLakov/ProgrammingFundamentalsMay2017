using System;
using System.Text;

namespace _03.KarateString
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());
            int strength = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    strength += int.Parse(input[i + 1].ToString());
                    i++;

                    while (i < input.Length && strength > 0)
                    {
                        if (input[i] == '>')
                        {
                            break;
                        }
                        input.Remove(i, 1);
                        strength--;
                    }
                    i--;
                }
            }
            Console.WriteLine(input);
        }
    }
}
