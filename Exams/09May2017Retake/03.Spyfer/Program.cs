using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _03.Spyfer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> coords = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < coords.Count; i++)
            {
                if (i != 0 && i != coords.Count - 1)
                {
                    if (coords[i] == coords[i - 1] + coords[i + 1])
                    {
                        coords.RemoveAt(i + 1);
                        coords.RemoveAt(i - 1);
                        i = 0;
                    }
                }
                else if (i == 0 && coords[i] == coords[i + 1])
                {
                    coords.RemoveAt(i + 1);
                    i = 0;
                }
                else if (i == coords.Count - 1 && coords[i] == coords[i - 1])
                {
                    coords.RemoveAt(i - 1);
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ", coords));
        }
    }
}
