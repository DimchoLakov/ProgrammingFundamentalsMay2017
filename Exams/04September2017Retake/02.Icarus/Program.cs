using System;
using System.Linq;

namespace _02.Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int startIndex = int.Parse(Console.ReadLine());
            int currentDamage = 1;

            string input = Console.ReadLine();

            while (input != "Supernova")
            {
                string[] tokens = input.Split(' ');

                string command = tokens[0];
                int steps = int.Parse(tokens[1]);

                if (command == "left")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        if (startIndex - 1 < 0)
                        {
                            startIndex = numbers.Length - 1;
                            currentDamage++;
                            numbers[startIndex] -= currentDamage;
                        }
                        else
                        {
                            numbers[startIndex - 1] -= currentDamage;
                            startIndex--;
                        }
                    }
                }
                else if (command == "right")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        if (startIndex + 1 > numbers.Length - 1)
                        {
                            startIndex = 0;
                            currentDamage++;
                            numbers[startIndex] -= currentDamage;
                        }
                        else
                        {
                            numbers[startIndex + 1] -= currentDamage;
                            startIndex++;
                        }
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
