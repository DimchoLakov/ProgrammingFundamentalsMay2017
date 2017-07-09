using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _09.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> items = new Dictionary<string, int>();
            Dictionary<string, int> junk = new Dictionary<string, int>();

            bool hasObtainedItem = false;

            string specialItem = string.Empty;

            while (!hasObtainedItem)
            {
                string input = Console.ReadLine().ToLower();
                string[] tokens = input.Split(' ');
                for (int i = 0; i < tokens.Length; i += 2)
                {
                    int quantity = int.Parse(tokens[i]);
                    string resources = tokens[i + 1];

                    if (!items.ContainsKey("shards"))
                    {
                        items.Add("shards", 0);
                    }
                    if (!items.ContainsKey("fragments"))
                    {
                        items.Add("fragments", 0);
                    }
                    if (!items.ContainsKey("motes"))
                    {
                        items.Add("motes", 0);
                    }

                    if (resources == "shards")
                    {
                        items[resources] += quantity;
                        if (items[resources] >= 250)
                        {
                            items[resources] -= 250;
                            hasObtainedItem = true;
                            specialItem = "Shadowmourne";
                        }
                    }
                    else if (resources == "fragments")
                    {
                        items[resources] += quantity;
                        if (items[resources] >= 250)
                        {
                            items[resources] -= 250;
                            hasObtainedItem = true;
                            specialItem = "Valanyr";
                        }
                    }
                    else if (resources == "motes")
                    {
                        items[resources] += quantity;
                        if (items[resources] >= 250)
                        {
                            items[resources] -= 250;
                            hasObtainedItem = true;
                            specialItem = "Dragonwrath";
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(resources))
                        {
                            junk.Add(resources, quantity);
                        }
                        else
                        {
                            junk[resources] += quantity;
                        }
                    }

                    if (hasObtainedItem)
                    {
                        break;
                    }

                }
               
            }


            if (hasObtainedItem)
            {
                Console.WriteLine($"{specialItem} obtained!");
            }

            foreach (KeyValuePair<string, int> resourcePair in items.OrderByDescending(x => x.Value).ThenBy(name => name.Key))
            {
                Console.WriteLine($"{resourcePair.Key}: {resourcePair.Value}");
            }

            foreach (KeyValuePair<string, int> resourcePair in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{resourcePair.Key}: {resourcePair.Value}");
            }

        }
    }
}
