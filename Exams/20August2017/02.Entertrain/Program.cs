using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Entertrain
{
    class Program
    {
        static void Main(string[] args)
        {
            int locomotivePower = int.Parse(Console.ReadLine());

            List<int> wagonList = new List<int>();

            string input = Console.ReadLine();

            while (input != "All ofboard!")
            {
                int wagonWeight;
                var parseWagonWeight = int.TryParse(input, out wagonWeight);

                if (parseWagonWeight)
                {
                    wagonList.Add(wagonWeight);
                    int wagonSum = wagonList.Sum();
                    int average = 0;
                    if (wagonSum > locomotivePower)
                    {
                        average = wagonSum / wagonList.Count;
                        wagonList = RemoveClosestToAverageWagon(average, wagonList);
                    }
                }

                input = Console.ReadLine();
            }

            wagonList.Reverse();
            wagonList.Add(locomotivePower);
            Console.WriteLine(string.Join(" ", wagonList));
        }

        static List<int> RemoveClosestToAverageWagon(int average, List<int> wagonList)
        {
            var nearest = wagonList.OrderBy(x => Math.Abs(x - average)).First();
            wagonList.Remove(nearest);
            return wagonList;
        }
    }
}
