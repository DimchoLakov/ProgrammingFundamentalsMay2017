using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Snowwhite
{
    class Dwarf
    {
        public string Name { get; set; }
        public string HatColor { get; set; }
        public long Physics { get; set; }

        public static Dwarf GetDwarf(string name, string hatColor, long physics)
        {
            return new Dwarf
            {
                Name = name,
                HatColor = hatColor,
                Physics = physics
            };
        }
    }

    class Program
    {
        static void Main()
        {
            List<Dwarf> dwarfs = new List<Dwarf>();

            Dictionary<string, int> hatColorCount = new Dictionary<string, int>();
                 
            string input = Console.ReadLine();

            while (input != "Once upon a time")
            {
                string[] tokens = input.Split(new string[] {" <:> "}, StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];
                string hatColor = tokens[1];
                long physics = long.Parse(tokens[2]);

                if (dwarfs.Any(d => d.Name == name))
                {
                    Dwarf dwarf = dwarfs.First(d => d.Name == name);
                    if (dwarf.HatColor == hatColor)
                    {
                        if (physics > dwarf.Physics)
                        {
                            dwarf.Physics = physics;
                        }
                    }
                    else
                    {
                        dwarfs.Add(Dwarf.GetDwarf(name, hatColor, physics));
                        if (!hatColorCount.ContainsKey(hatColor))
                        {
                            hatColorCount.Add(hatColor, 1);
                        }
                        else
                        {
                            hatColorCount[hatColor]++;
                        }
                    }
                }
                else
                {
                    dwarfs.Add(Dwarf.GetDwarf(name, hatColor, physics));
                    if (!hatColorCount.ContainsKey(hatColor))
                    {
                        hatColorCount.Add(hatColor, 1);
                    }
                    else
                    {
                        hatColorCount[hatColor]++;
                    }
                }

                input = Console.ReadLine();
            }
            
            foreach (var dwarf in dwarfs.OrderByDescending(d => d.Physics).ThenByDescending(dw => hatColorCount[dw.HatColor]))
            {
                Console.WriteLine($"({dwarf.HatColor}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }
    }
}
