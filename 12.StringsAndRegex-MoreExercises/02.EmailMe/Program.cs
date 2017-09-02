using System;
using System.Linq;

namespace _02.EmailMe
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string[] tokens = email.Split('@');

            string firstPart = tokens[0];
            string secondPart = tokens[1];

            int firstSum = firstPart.Sum(a => a);
            int secondSum = secondPart.Sum(a => a);
            int diff = firstSum - secondSum;

            if (diff >= 0)
            {
                Console.WriteLine($"Call her!");
            }
            else
            {
                Console.WriteLine($"She is not the one.");
            }

        }
    }
}
