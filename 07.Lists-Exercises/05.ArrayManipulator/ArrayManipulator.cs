using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string line = Console.ReadLine();

            while (line != "print")
            {
                string[] tokens = line.Split();

                string command = tokens[0];

                if (command == "add")
                {
                    int index = int.Parse(tokens[1]);
                    int element = int.Parse(tokens[2]);
                    list.Insert(index, element);
                }
                else if (command == "addMany")
                {
                    int index = int.Parse(tokens[1]);
                    List<int> elements = new List<int>();

                    for (int i = 2; i < tokens.Length; i++)
                    {
                        int currentNumber = int.Parse(tokens[i]);
                        elements.Add(currentNumber);
                    }
                    list.InsertRange(index, elements);
                }
                else if (command == "contains")
                {
                    int element = int.Parse(tokens[1]);
                    int index = list.IndexOf(element);
                    Console.WriteLine(index);
                }
                else if (command == "remove")
                {
                    int index = int.Parse(tokens[1]);
                    list.RemoveAt(index);
                }
                else if (command == "shift")
                {
                    int count = int.Parse(tokens[1]) % list.Count;
                    for (int i = 0; i < count; i++)
                    {
                        list.Add(list[0]);
                        list.RemoveAt(0);
                    }
                }
                else if (command == "sumPairs")
                {
                    List<int> sum = new List<int>();

                    for (int i = 0; i < list.Count; i += 2)
                    {
                        int currentElement = list[i];
                        int nextElement = 0;

                        if (i < list.Count - 1)
                        {
                            nextElement = list[i + 1];
                        }

                        int elementsSum = currentElement + nextElement;

                        sum.Add(elementsSum);
                    }
                    list = sum;
                }
                line = Console.ReadLine();
            }
            Console.WriteLine("[" + string.Join(", ", list) + "]");
        }
    }
}