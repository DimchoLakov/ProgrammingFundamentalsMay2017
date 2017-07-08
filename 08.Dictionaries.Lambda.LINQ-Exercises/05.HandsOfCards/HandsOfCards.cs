using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HandsOfCards
{
    class HandsOfCards
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> initialInput = input.Split(new char[] { ':'}, StringSplitOptions.RemoveEmptyEntries).ToList();

            Dictionary<string, List<int>> playersAndCards = new Dictionary<string, List<int>>();

            while (input != "JOKER")
            {
                List<string> cards = initialInput[1].Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                int cardPoints = 0;

                string player = initialInput[0];

                for (int i = 0; i < cards.Count; i++)
                {
                    string singleCard = cards[i];
                    cardPoints = CalculateCards(singleCard); //calculate points for each card
                    if (!playersAndCards.ContainsKey(player))
                    {
                        playersAndCards[player] = new List<int>();
                    }
                    playersAndCards[player].Add(cardPoints);
                }
                
                input = Console.ReadLine();
                initialInput = input.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            foreach (KeyValuePair<string, List<int>> player in playersAndCards)
            {
                int result = player.Value.Distinct().ToList().Sum();
                Console.WriteLine($"{player.Key}: {string.Join(" ", result)}");
            }

        }

        static int CalculateCards(string singleCard)
        {
            Dictionary<string, int> power = new Dictionary<string, int>();
            power.Add("2", 2);
            power.Add("3", 3);
            power.Add("4", 4);
            power.Add("5", 5);
            power.Add("6", 6);
            power.Add("7", 7);
            power.Add("8", 8);
            power.Add("9", 9);
            power.Add("10", 10);
            power.Add("J", 11);
            power.Add("Q", 12);
            power.Add("K", 13);
            power.Add("A", 14);

            Dictionary<string, int> type = new Dictionary<string, int>();
            type.Add("C", 1);
            type.Add("D", 2);
            type.Add("H", 3);
            type.Add("S", 4);

            string firstChar = singleCard.Substring(0, singleCard.Length - 1);
            string secondChar = singleCard.Substring(singleCard.Length - 1);
            int singleCardPoints = 0;

            if (power.ContainsKey(firstChar) && type.ContainsKey(secondChar))
            {
                singleCardPoints = power[firstChar] * type[secondChar];

            }

            return singleCardPoints;
        }
        
    }
}
