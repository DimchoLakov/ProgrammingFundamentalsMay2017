using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.BoatSimulator
{
    class BoatSimulator
    {
        static void Main(string[] args)
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            int first = firstBoat;
            int second = secondBoat;
            int n = int.Parse(Console.ReadLine());
            int firstBoatSpeed = 0;
            int secondBoatSpeed = 0;
            for (int i = 1; i <= n; i++)
            {
                string speedString = Console.ReadLine();
                if (i % 2 == 1)
                {
                    if (speedString != "UPGRADE")
                    {
                        firstBoatSpeed += speedString.Length;
                    }
                    else
                    {
                        first = first + 3;
                        second = second + 3;
                    }
                }
                else if (i % 2 == 0)
                {
                    if (speedString != "UPGRADE")
                    {
                        secondBoatSpeed += speedString.Length;
                    }
                    else
                    {
                        first = first + 3;
                        second = second + 3;
                    }
                }
                if (firstBoatSpeed >= 50)
                {
                    Console.WriteLine((char)first);
                    return;
                }
                else if (secondBoatSpeed >= 50)
                {
                    Console.WriteLine((char)second);
                    return;
                }
            }
            if (firstBoatSpeed > secondBoatSpeed)
            {
                Console.WriteLine((char)first);
            }
            else
            {
                Console.WriteLine((char)second);
            }
        }
    }
}
