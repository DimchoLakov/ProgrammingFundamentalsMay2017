using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _02.CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(' ');
                string command = tokens[0];

                switch (command)
                {
                    case "reverse":

                        int startIndex = int.Parse(tokens[2]);
                        int count = int.Parse(tokens[4]);
                        if (startIndex >= 0 && 
                            startIndex < myList.Count && 
                            count >= 0 && 
                            startIndex + count <= myList.Count)
                        {
                            myList.Reverse(startIndex, count);
                            //myList = ReversePortionOfElements(myList, startIndex, count);
                        }
                        else
                        {
                            Console.WriteLine($"Invalid input parameters.");
                        }

                        break;
                    case "sort":

                        int sortStartIndex = int.Parse(tokens[2]);
                        int sortCount = int.Parse(tokens[4]);

                        if (sortStartIndex >= 0 && 
                            sortStartIndex < myList.Count && 
                            sortCount >= 0 && 
                            sortStartIndex + sortCount <= myList.Count)
                        {
                            myList.Sort(sortStartIndex, sortCount, StringComparer.InvariantCulture);
                            //myList = SortPortionOfElements(myList, sortStartIndex, sortCount);
                        }
                        else
                        {
                            Console.WriteLine($"Invalid input parameters.");
                        }

                        break;
                    case "rollLeft":

                        int rollLeftCount = int.Parse(tokens[1]);
                        if (rollLeftCount >= 0)
                        {
                            myList = RollElementsToTheLeft(myList, rollLeftCount);
                        }
                        else
                        {
                            Console.WriteLine($"Invalid input parameters.");
                        }

                        break;
                    case "rollRight":

                        int rollRightCount = Int32.Parse(tokens[1]);
                        if (rollRightCount >= 0)
                        {
                            myList = RollElementsToTheRight(myList, rollRightCount);
                        }
                        else
                        {
                            Console.WriteLine($"Invalid input parameters.");
                        }

                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", myList)}]");
        }

        static List<string> RollElementsToTheRight(List<string> myList, int rollRightCount)
        {
            int jumps = rollRightCount % myList.Count;

            for (int j = 0; j < jumps; j++)
            {
                string lastElement = myList[myList.Count - 1];
                for (int i = myList.Count - 1; i > 0; i--)
                {
                    myList[i] = myList[i - 1];
                }
                myList[0] = lastElement;
            }
            return myList;
        }

        static List<string> RollElementsToTheLeft(List<string> myList, int rollLeftCount)
        {
            int jumps = rollLeftCount % myList.Count;

            for (int j = 0; j < jumps; j++)
            {
                string firstElement = myList[0];
                for (int i = 0; i < myList.Count - 1; i++)
                {
                    myList[i] = myList[i + 1];
                }
                myList[myList.Count - 1] = firstElement;
            }
            return myList;
        }

        static List<string> SortPortionOfElements(List<string> myList, int sortStartIndex, int sortCount)
        {
            List<string> sortedPortion = myList.Skip(sortStartIndex).Take(sortCount).OrderBy(x => x).ToList();
            myList.RemoveRange(sortStartIndex, sortCount);
            myList.InsertRange(sortStartIndex, sortedPortion);

            return myList;
        }

        static List<string> ReversePortionOfElements(List<string> myList, int startIndex, int count)
        {
            List<string> reversedPortion = myList.Skip(startIndex).Take(count).Reverse().ToList();
            myList.RemoveRange(startIndex, count);
            myList.InsertRange(startIndex, reversedPortion);

            return myList;
        }
    }
}