using System;
using System.Collections.Generic;

namespace _03.MinesTask
{
    class MinesTask
    {
        static void Main(string[] args)
        {
            var treasureDict = new Dictionary<string, int>();

            string resources = Console.ReadLine();
            if (resources == "stop")
            {
                return;
            }
            int number = int.Parse(Console.ReadLine());

            while (resources != "stop")
            {

                if (treasureDict.ContainsKey(resources))
                {
                    treasureDict[resources] += number;
                }
                else
                {
                    treasureDict.Add(resources, number);
                }

                resources = Console.ReadLine();
                if (resources == "stop")
                {
                    break;
                }
                number = int.Parse(Console.ReadLine());
            }
            foreach (var treasure in treasureDict)
            {
                Console.WriteLine($"{treasure.Key} -> {treasure.Value}");   
            }
        }
    }
}
