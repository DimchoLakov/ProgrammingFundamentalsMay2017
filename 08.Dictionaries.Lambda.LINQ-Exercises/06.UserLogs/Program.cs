using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> logs = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            List<string> tokens = input.Split(' ').ToList();

            while (input != "end")
            {
                List<string> ipInfo = tokens[0].Split('=').ToList();
                List<string> userInfo = tokens[2].Split('=').ToList();

                string ipAdress = ipInfo[1];
                string username = userInfo[1];

                if (!logs.ContainsKey(username))
                {
                    logs.Add(username, new Dictionary<string, int>());
                }

                if (!logs[username].ContainsKey(ipAdress))
                {
                    logs[username].Add(ipAdress, 1);
                }
                else
                {
                    logs[username][ipAdress]++;
                }


                input = Console.ReadLine();
                tokens = input.Split(' ').ToList();
            }

            foreach (var user in logs.OrderBy(u => u.Key))
            {
                Console.WriteLine($"{user.Key}: ");
                var result = new List<string>();
                foreach (var ip in user.Value)
                {
                    result.Add($"{ ip.Key} => {ip.Value}");
                }
                Console.WriteLine(string.Join(", ", result) + ".");
            }

        }
    }
}
