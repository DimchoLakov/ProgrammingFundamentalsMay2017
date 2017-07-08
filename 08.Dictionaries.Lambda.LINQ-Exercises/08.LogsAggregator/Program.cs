using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());


            SortedDictionary<string, Dictionary<string, int>> logs = new SortedDictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(' ');

                string ip = tokens[0];
                string user = tokens[1];
                int duration = int.Parse(tokens[2]);

                if (! logs.ContainsKey(user))
                {
                    logs.Add(user, new Dictionary<string, int>());
                }

                if (! logs[user].ContainsKey(ip))
                {
                    logs[user].Add(ip, duration);
                }
                else
                {
                    logs[user][ip] += duration;
                }
                
            }

            foreach (KeyValuePair<string, Dictionary<string, int>> keyValuePair in logs)
            {
                var durationSum = keyValuePair.Value.Values.Sum();

                List<string> sortedIPs = keyValuePair.Value.Keys.OrderBy(x => x).Distinct().ToList();

                Console.WriteLine($"{keyValuePair.Key}: {durationSum} [{string.Join(", ", sortedIPs)}]");
            }

        }
    }
}
