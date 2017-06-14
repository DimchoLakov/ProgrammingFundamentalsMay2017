using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MagicLetter
{
    class MagicLetter
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());
            char avoidLetter = char.Parse(Console.ReadLine());

            for (char i = startLetter; i <= endLetter; i++)
            {
                for (char k = startLetter; k <= endLetter; k++)
                {
                    for (char m = startLetter; m <= endLetter; m++)
                    {
                        if (avoidLetter != i && avoidLetter != k && avoidLetter != m)
                        {
                            Console.Write($"{i}{k}{m} ");
                        }
                    }
                }
            }
        }
    }
}
