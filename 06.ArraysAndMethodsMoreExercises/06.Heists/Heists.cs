using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _06.Heists
{
    class Heists
    {
        static void Main(string[] args)
        {
            long[] priceOfGoodies = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long priceOfJewels = priceOfGoodies[0];
            long priceOfGold = priceOfGoodies[1];
            long moneyStolen = 0L;
            long moneyLost = 0L;
            while (true)
            {
                string[] lootAndHeistExpenses = Console.ReadLine().Split(' ').ToArray();
                if (lootAndHeistExpenses[0] == "Jail" && lootAndHeistExpenses[1] == "Time")
                {
                    break;
                }
                string loot = lootAndHeistExpenses[0];
                long expenses = long.Parse(lootAndHeistExpenses[1]);
                char[] lootType = lootAndHeistExpenses[0].ToCharArray();

                for (int i = 0; i < lootType.Length; i++)
                {
                    if (lootType[i] == '%')
                    {
                        moneyStolen += priceOfJewels;
                    }
                    else if (lootType[i] == '$')
                    {
                        moneyStolen += priceOfGold;
                    }
                }
                moneyLost -= expenses;
            }
            long totalEarnings = moneyStolen - Math.Abs(moneyLost);
            if (moneyStolen >= Math.Abs(moneyLost))
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalEarnings}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {Math.Abs(totalEarnings)}.");
            }
        }
    }
}
