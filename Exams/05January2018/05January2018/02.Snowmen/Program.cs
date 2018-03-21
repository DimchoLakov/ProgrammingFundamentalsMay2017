using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Snowmen
{
    class Program
    {
        static void Main()
        {
            List<int> snowmen = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            HashSet<int> lostOrSuicided = new HashSet<int>();

            while (snowmen.Count != 1)
            {
                for (int i = 0; i < snowmen.Count; i++)
                {
                    int attackerIndex = i;
                    int targetIndex = snowmen[i];
                    int length = snowmen.Count;

                    if (snowmen.Count - lostOrSuicided.Count == 1)
                    {
                        return;
                    }

                    if (lostOrSuicided.Contains(i))
                    {
                        continue;
                    }

                    if (targetIndex >= length)
                    {
                        targetIndex = targetIndex % length;
                    }

                    if (attackerIndex == targetIndex)
                    {
                        Console.WriteLine($"{attackerIndex} performed harakiri");
                        lostOrSuicided.Add(attackerIndex);
                        continue;
                    }

                    int diff = Math.Abs(attackerIndex - targetIndex);

                    if (diff % 2 == 0)
                    {
                        Console.WriteLine($"{attackerIndex} x {targetIndex} -> {attackerIndex} wins");
                        lostOrSuicided.Add(targetIndex);
                    }
                    else if (diff % 2 != 0)
                    {
                        Console.WriteLine($"{attackerIndex} x {targetIndex} -> {targetIndex} wins");
                        lostOrSuicided.Add(attackerIndex);
                    }

                }

                foreach (int s in lostOrSuicided.OrderByDescending(x => x))
                {
                    if (s >= 0 && s <= snowmen.Count - 1)
                    {
                        snowmen.RemoveAt(s);
                    }
                }

                lostOrSuicided.Clear();
            }
        }
    }
}
