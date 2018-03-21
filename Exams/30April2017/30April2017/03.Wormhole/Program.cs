using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Wormhole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wormholes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int count = 0;
            for (int i = 0; i < wormholes.Count; i++)
            {
                if (wormholes[i] != 0)
                {
                    if (wormholes[i] >= 0 && wormholes[i] < wormholes.Count - 1)
                    {
                        int jump = wormholes[i];
                        wormholes[i] = 0;
                        i = jump;
                    }
                }
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
