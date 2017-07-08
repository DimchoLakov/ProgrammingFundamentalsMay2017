using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DictionariesCountRealNumbers
{
    class DictionariesCountRealNumbers
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            SortedDictionary<double, int> dict = new SortedDictionary<double, int>();

            foreach (var num in numbers)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict[num] = 1;
                }
            }

            foreach (var num in dict)
            {
                Console.WriteLine(num.Key + " -> " + num.Value);
            }
        }
    }
}
