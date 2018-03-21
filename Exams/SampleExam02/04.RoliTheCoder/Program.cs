using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;

namespace _04.RoliTheCoder
{
    class Participant
    {
        public string Participants { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Dictionary<string, List<string>>> events = new Dictionary<int, Dictionary<string, List<string>>>();

            string input = Console.ReadLine();

            while (input != "Time for Code")
            {
                string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 2)
                {
                    int id = int.Parse(tokens[0]);
                    string eventName = tokens[1];
                    if (!events.ContainsKey(id))
                    {
                        if (eventName.StartsWith("#"))
                        {
                            events.Add(id, new Dictionary<string, List<string>>());
                            events[id].Add(eventName.Remove(0, 1), new List<string>());
                        }
                    }
                }
                else if (tokens.Length > 2)
                {
                    if (tokens[1].StartsWith("#"))
                    {
                        int id = int.Parse(tokens[0]);
                        string eventName = tokens[1].Remove(0, 1);
                        if (!events.ContainsKey(id))
                        {
                            events.Add(id, new Dictionary<string, List<string>>());
                            events[id].Add(eventName, new List<string>());
                        }
                        if (events.ContainsKey(id) && events[id].ContainsKey(eventName))
                        {
                            for (int i = 2; i < tokens.Length; i++)
                            {
                                if (tokens[i].StartsWith("@"))
                                {
                                    events[id][eventName].Add(tokens[i]);
                                }
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
            foreach (var idEventPair in events)
            {
                foreach (var eventParticipants in idEventPair.Value)
                {
                    string nameOfEvent = eventParticipants.Key;
                    if (! result.ContainsKey(nameOfEvent))
                    {
                        result.Add(nameOfEvent, new List<string>());
                    }
                    for (int i = 0; i < eventParticipants.Value.Count; i++)
                    {
                        if (! result[nameOfEvent].Contains(eventParticipants.Value[i]))
                        {
                            result[nameOfEvent].Add(eventParticipants.Value[i]);
                        }
                    }
                }
            }

            foreach (var eventPair in result.OrderByDescending(x => x.Value.Count).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{eventPair.Key} - {eventPair.Value.Count}");
                foreach (var participants in eventPair.Value.OrderBy(x => x))
                {
                    Console.WriteLine(participants);
                }
            }
        }
    }
}
