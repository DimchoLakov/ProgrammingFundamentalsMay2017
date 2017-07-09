using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _10.SerbianUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            Dictionary<string, Dictionary<string, long>> events = new Dictionary<string, Dictionary<string, long>>();

            while (input != "End")
            {
                bool isInputValid = CheckInput(input);
                if (!isInputValid)
                {
                    return;
                } 

                string[] tokens = input.Split('@');
                string tempSinger = tokens[0];
                string[] singer = tempSinger.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string singerName = string.Join(" ", singer);
                
                string[] temp = tokens[1].Split(' ');

                string venue = string.Empty;

                long ticketPrice;
                long ticketsCount;
                bool isTicketValid = long.TryParse(temp[temp.Length - 1], out ticketsCount);
                bool isPriceValid = long.TryParse(temp[temp.Length - 2], out ticketPrice);

                if (temp.Length >= 3 && temp.Length <= 5 && singer.Length > 0 && singer.Length <= 3 && tempSinger.EndsWith(" ") && isPriceValid && isTicketValid)
                {
                    for (long i = 0; i < temp.Length - 2; i++)
                    {
                        venue += temp[i] + " ";
                    }
                    venue = venue.TrimEnd(' ');

                    if (!events.ContainsKey(venue))
                    {
                        events.Add(venue, new Dictionary<string, long>());
                    }

                    if (!events[venue].ContainsKey(singerName))
                    {
                        events[venue].Add(singerName, ticketsCount * ticketPrice);
                    }
                    else
                    {
                        events[venue][singerName] += ticketsCount * ticketPrice;
                    }

                }

                input = Console.ReadLine();
                tokens = input.Split('@');

            }

            foreach (KeyValuePair<string, Dictionary<string, long>> destination in events)
            {
                Console.WriteLine(destination.Key);

                var singerList = destination.Value.OrderByDescending(x => x.Value);

                foreach (KeyValuePair<string, long> singerPair in singerList)
                {
                    Console.WriteLine($"#  {singerPair.Key} -> {singerPair.Value}");
                }
            }

        }

        static bool CheckInput(string input)
        {
            int count = 0;

            char[] symbols = input.ToCharArray();

            if (symbols.Length == 1 && symbols[0] == '@')
            {
                return false;
            }
            else if (symbols.Length > 1 && symbols.Contains('@'))
            {
                for (int i = 0; i < symbols.Length; i++)
                {
                    if (symbols[i] == '@')
                    {
                        count++;
                        if (count > 1)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (symbols.Length == 0)
            {
                return false;
            }
            else if (symbols.Length > 0)
            {
                if (!symbols.Contains('@'))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
