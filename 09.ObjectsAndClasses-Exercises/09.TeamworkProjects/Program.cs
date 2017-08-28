using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _09.TeamworkProjects
{
    class Team
    {
        public string Name { get; set; }
        public List<string> Members { get; set; }
        public string Creator { get; set; }

        public static Team Parse(string name, string creator, List<string> members)
        {
            Team newTeam = new Team
            {
                Creator = creator,
                Name = name,
                Members = new List<string>()
            };
            return newTeam;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Team> data = new List<Team>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                string creator = tokens[0];
                string teamName = tokens[1];

                if (data.Exists(c => c.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (data.Exists(c => c.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    data.Add(Team.Parse(teamName, creator, new List<string>()));
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            string input = Console.ReadLine();

            while (input != "end of assignment")
            {
                string[] tokens = input.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                string user = tokens[0];
                string teamToJoin = tokens[1];

                if (!data.Exists(c => c.Name == teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else if (data.Exists(c => c.Members.Contains(user)) || data.Exists(c => c.Creator == user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamToJoin}!");
                }
                else
                {
                    int indexOfTeam = data.FindIndex(i => i.Name == teamToJoin);
                    data[indexOfTeam].Members.Add(user);
                }
                input = Console.ReadLine();
            }
            List<string> disbandList = new List<string>();
            foreach (Team teamToDisband in data.Where(x => x.Members.Count == 0))
            {
                disbandList.Add(teamToDisband.Name);
            }
            data.RemoveAll(m => m.Members.Count == 0);

            foreach (Team team in data.OrderByDescending(t => t.Members.Count).ThenBy(a => a.Name))
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                foreach (string teamName in team.Members.OrderBy(e => e))
                {
                    Console.WriteLine($"-- {teamName}");
                }
            }

            Console.WriteLine($"Teams to disband:");

            foreach (string disbandedTeam in disbandList.OrderBy(x => x))
            {
                Console.WriteLine($"{disbandedTeam}");
            }

        }
    }
}
