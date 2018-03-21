using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.NetherRealms
{
    class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }

        public static Demon ParseDemon(string name, int health, double damage)
        {
            return new Demon { Name = name, Health = health, Damage = damage };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Demon> demons = new Dictionary<string, Demon>();
            string input = Console.ReadLine();

            string[] tokens = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            string healthPattern = @"[^\d\-\+\.\*\/]+";
            string damagePattern = @"(\-?\d+)(\.\d+)?";
            string symbolPattern = @"[\*\/]";

            for (int i = 0; i < tokens.Length; i++)
            {

                int totalHealth = 0;
                double totalDamage = 0d;

                Regex healthRegex = new Regex(healthPattern);
                MatchCollection healthMatches = healthRegex.Matches(tokens[i]);

                foreach (Match healthMatch in healthMatches)
                {
                    totalHealth += healthMatch.ToString().ToCharArray().Sum(x => x);
                }
                
                Regex damageRegex = new Regex(damagePattern);
                MatchCollection damageMatches = damageRegex.Matches(tokens[i]);

                foreach (Match damageMatch in damageMatches)
                {
                    totalDamage += double.Parse(damageMatch.ToString());
                }
                
                Regex symbolRegex = new Regex(symbolPattern);
                MatchCollection symbolMatches = symbolRegex.Matches(tokens[i]);

                foreach (Match symbolMatch in symbolMatches)
                {
                    switch (symbolMatch.Value)
                    {
                        case "/":
                            totalDamage /= 2;
                            break;
                        case "*":
                            totalDamage *= 2;
                            break;
                    }
                }
                string demonName = tokens[i];

                if (! demons.ContainsKey(demonName))
                {
                    demons.Add(demonName, Demon.ParseDemon(demonName, totalHealth, totalDamage));
                }
            }
            foreach (KeyValuePair<string, Demon> demon in demons.OrderBy(name => name.Key))
            {
                Console.WriteLine($"{demon.Key} - {demon.Value.Health} health, {demon.Value.Damage:f2} damage");
            }
        }
    }
}
