using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> teamsAndPoints = new Dictionary<string, long>();
            Dictionary<string, long> teamsAndGoals = new Dictionary<string, long>();

            string key = Console.ReadLine();
            string escapedKey = Regex.Escape(key);

            string pattern = string.Format($"(?<=({escapedKey}))(?<team>[A-Za-z]+)(?=({escapedKey}))");

            string input = Console.ReadLine();

            while (input != "final")
            {
                string[] tokens = input.Split(new Char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 4)
                {
                    Match firstMatch = Regex.Match(tokens[0], pattern);
                    Match secondMatch = Regex.Match(tokens[1], pattern);

                    string firstTeam = firstMatch.Groups["team"].Value;
                    string secondTeam = secondMatch.Groups["team"].Value;

                    string firstTeamName = ReverseString(firstTeam);
                    string secondTeamName = ReverseString(secondTeam);

                    long firstTeamGoals = long.Parse(tokens[2]);
                    long secondTeamGoals = long.Parse(tokens[3]);

                    long firstTeamPoints = 0;
                    long secondTeamPoints = 0;

                    AddTeamPointsAndGoals(firstTeamGoals, secondTeamGoals, firstTeamPoints, secondTeamPoints, teamsAndGoals, firstTeamName, secondTeamName, teamsAndPoints);
                }

                input = Console.ReadLine();
            }

            int place;
            PrintStandingTables(teamsAndPoints, teamsAndGoals, out place);
        }

        static void PrintStandingTables(Dictionary<string, long> teamsAndPoints, Dictionary<string, long> teamsAndGoals, out int place)
        {
            Console.WriteLine($"League standings:");
            place = 1;
            foreach (KeyValuePair<string, long> teamPointsPair in teamsAndPoints.OrderByDescending(x => x.Value)
                .ThenBy(name => name.Key))
            {
                Console.WriteLine($"{place}. {teamPointsPair.Key} {teamPointsPair.Value}");
                place++;
            }
            Console.WriteLine($"Top 3 scored goals:");
            foreach (KeyValuePair<string, long> teamGoalsPair in teamsAndGoals.OrderByDescending(x => x.Value)
                .ThenBy(name => name.Key).Take(3))
            {
                Console.WriteLine($"- {teamGoalsPair.Key} -> {teamGoalsPair.Value}");
            }
        }

        static void AddTeamPointsAndGoals(long firstTeamGoals, long secondTeamGoals, long firstTeamPoints,
            long secondTeamPoints, Dictionary<string, long> teamsAndGoals, string firstTeamName, string secondTeamName,
            Dictionary<string, long> teamsAndPoints)
        {
            if (firstTeamGoals > secondTeamGoals)
            {
                firstTeamPoints = 3;
            }
            else if (firstTeamGoals < secondTeamGoals)
            {
                secondTeamPoints = 3;
            }
            else if (firstTeamGoals == secondTeamGoals)
            {
                firstTeamPoints = 1;
                secondTeamPoints = 1;
            }

            if (!teamsAndGoals.ContainsKey(firstTeamName))
            {
                teamsAndGoals.Add(firstTeamName, firstTeamGoals);
            }
            else
            {
                teamsAndGoals[firstTeamName] += firstTeamGoals;
            }

            if (!teamsAndGoals.ContainsKey(secondTeamName))
            {
                teamsAndGoals.Add(secondTeamName, secondTeamGoals);
            }
            else
            {
                teamsAndGoals[secondTeamName] += secondTeamGoals;
            }

            if (!teamsAndPoints.ContainsKey(firstTeamName))
            {
                teamsAndPoints.Add(firstTeamName, firstTeamPoints);
            }
            else
            {
                teamsAndPoints[firstTeamName] += firstTeamPoints;
            }


            if (!teamsAndPoints.ContainsKey(secondTeamName))
            {
                teamsAndPoints.Add(secondTeamName, secondTeamPoints);
            }
            else
            {
                teamsAndPoints[secondTeamName] += secondTeamPoints;
            }
        }
        static string ReverseString(string input)
        {
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr).ToUpper();
        }
    }
}
