using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> nums = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(' ');
                string command = tokens[0];

                switch (command)
                {
                    case "exchange":
                        int exchangeIndex;
                        if (SplitAndExchange(tokens, out exchangeIndex, ref nums, ref input)) continue;
                        break;
                    case "max":
                        string maxOddOrMaxEven = tokens[1];
                        GetMaxOddOrEvenIndex(maxOddOrMaxEven, nums);
                        break;
                    case "min":
                        string minOddOrMinEven = tokens[1];
                        GetMinOddOrEvenIndex(minOddOrMinEven, nums);
                        break;
                    case "first":
                        string firstOddOrFirstEven = tokens[2];
                        int firstCount;
                        if (GetFirstOddOrEvenElements(tokens, nums, firstOddOrFirstEven, out firstCount, ref input)) continue;
                        break;
                    case "last":
                        string lastOddOrLastEven = tokens[2];
                        int lastCount;
                        if (GetLastOddOrEvenElements(tokens, nums, lastOddOrLastEven, out lastCount, ref input)) continue;
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", nums) + "]");
        }

        static bool GetLastOddOrEvenElements(string[] tokens, List<long> nums, string lastOddOrLastEven, out int lastCount,
            ref string input)
        {
            lastCount = int.Parse(tokens[1]);
            if (lastCount > nums.Count)
            {
                Console.WriteLine($"Invalid count");
                input = Console.ReadLine();
                return true;
            }
            List<long> lastOddOrEvenElementsList = new List<long>();
            if (lastOddOrLastEven == "odd")
            {
                lastOddOrEvenElementsList.AddRange(nums);
                lastOddOrEvenElementsList.Reverse();
                List<long> result = lastOddOrEvenElementsList.Where(x => x % 2 != 0).ToList().Take(lastCount).ToList();
                if (result.Count < lastCount)
                {
                    result = new List<long>();
                    result = lastOddOrEvenElementsList.Where(x => x % 2 != 0).ToList();
                }
                result.Reverse();
                Console.WriteLine($"[{string.Join(", ", result)}]");
            }
            else if (lastOddOrLastEven == "even")
            {
                lastOddOrEvenElementsList.AddRange(nums);
                lastOddOrEvenElementsList.Reverse();
                List<long> result = lastOddOrEvenElementsList.Where(x => x % 2 == 0).ToList().Take(lastCount).ToList();
                if (result.Count < lastCount)
                {
                    result = new List<long>();
                    result = lastOddOrEvenElementsList.Where(x => x % 2 == 0).ToList();
                }
                result.Reverse();
                Console.WriteLine($"[{string.Join(", ", result)}]");
            }
            return false;
        }

        static bool GetFirstOddOrEvenElements(string[] tokens, List<long> nums, string firstOddOrFirstEven,
            out int firstCount, ref string input)
        {
            firstCount = int.Parse(tokens[1]);
            if (firstCount > nums.Count)
            {
                Console.WriteLine($"Invalid count");
                input = Console.ReadLine();
                return true;
            }
            List<long> firstOddOrEvenElementsList = new List<long>();
            if (firstOddOrFirstEven == "odd")
            {
                firstOddOrEvenElementsList = nums.Where(x => x % 2 != 0).ToList().Take(firstCount).ToList();
                if (firstOddOrEvenElementsList.Count < firstCount)
                {
                    firstOddOrEvenElementsList = new List<long>();
                    firstOddOrEvenElementsList = nums.Where(x => x % 2 != 0).ToList();
                }
                Console.WriteLine($"[{string.Join(", ", firstOddOrEvenElementsList)}]");
            }
            else if (firstOddOrFirstEven == "even")
            {
                firstOddOrEvenElementsList = nums.Where(x => x % 2 == 0).ToList().Take(firstCount).ToList();
                if (firstOddOrEvenElementsList.Count < firstCount)
                {
                    firstOddOrEvenElementsList = new List<long>();
                    firstOddOrEvenElementsList = nums.Where(x => x % 2 == 0).ToList();
                }
                Console.WriteLine($"[{string.Join(", ", firstOddOrEvenElementsList)}]");
            }
            return false;
        }

        static void GetMinOddOrEvenIndex(string minOddOrMinEven, List<long> nums)
        {
            if (minOddOrMinEven == "odd")
            {
                List<long> minOddElementsList = nums.Where(x => x % 2 != 0).OrderBy(x => x).Take(2).ToList();
                if (minOddElementsList.Count > 0)
                {
                    int indexOfMinOddElement;
                    if (minOddElementsList.Count == 2 && minOddElementsList[0] == minOddElementsList[1])
                    {
                        indexOfMinOddElement = nums.LastIndexOf(minOddElementsList[0]);
                    }
                    else
                    {
                        indexOfMinOddElement = nums.IndexOf(minOddElementsList[0]);
                    }
                    Console.WriteLine(indexOfMinOddElement);
                }
                else
                {
                    Console.WriteLine($"No matches");
                }
            }
            else if (minOddOrMinEven == "even")
            {
                List<long> minEvenElementsList = nums.Where(x => x % 2 == 0).OrderBy(x => x).Take(2).ToList();
                if (minEvenElementsList.Count > 0)
                {
                    int indexOfMinEvenElement;
                    if (minEvenElementsList.Count == 2 && minEvenElementsList[0] == minEvenElementsList[1])
                    {
                        indexOfMinEvenElement = nums.LastIndexOf(minEvenElementsList[0]);
                    }
                    else
                    {
                        indexOfMinEvenElement = nums.IndexOf(minEvenElementsList[0]);
                    }
                    Console.WriteLine(indexOfMinEvenElement);
                }
                else
                {
                    Console.WriteLine($"No matches");
                }
            }
        }

        static void GetMaxOddOrEvenIndex(string maxOddOrMaxEven, List<long> nums)
        {
            if (maxOddOrMaxEven == "odd")
            {
                List<long> maxOddElementsList = nums.Where(x => x % 2 != 0).OrderByDescending(x => x).Take(2).ToList();
                if (maxOddElementsList.Count > 0)
                {
                    int indexOfMaxOddElement;
                    if (maxOddElementsList.Count > 1 && maxOddElementsList[0] == maxOddElementsList[1])
                    {
                        indexOfMaxOddElement = nums.LastIndexOf(maxOddElementsList[0]);
                    }
                    else
                    {
                        indexOfMaxOddElement = nums.IndexOf(maxOddElementsList[0]);
                    }
                    Console.WriteLine(indexOfMaxOddElement);
                }
                else
                {
                    Console.WriteLine($"No matches");
                }
            }
            else if (maxOddOrMaxEven == "even")
            {
                List<long> maxEvenElementsList = nums.Where(x => x % 2 == 0).OrderByDescending(x => x).Take(2).ToList();
                if (maxEvenElementsList.Count > 0)
                {
                    int indexOfMaxEvenElement;
                    if (maxEvenElementsList.Count > 1 && maxEvenElementsList[0] == maxEvenElementsList[1])
                    {
                        indexOfMaxEvenElement = nums.LastIndexOf(maxEvenElementsList[0]);
                    }
                    else
                    {
                        indexOfMaxEvenElement = nums.IndexOf(maxEvenElementsList[0]);
                    }
                    Console.WriteLine(indexOfMaxEvenElement);
                }
                else
                {
                    Console.WriteLine($"No matches");
                }
            }
        }

        static bool SplitAndExchange(string[] tokens, out int exchangeIndex, ref List<long> nums, ref string input)
        {
            exchangeIndex = int.Parse(tokens[1]);
            if (exchangeIndex < 0 || exchangeIndex > nums.Count - 1)
            {
                Console.WriteLine($"Invalid index");
                input = Console.ReadLine();
                return true;
            }
            exchangeIndex++;
            var firstHalf = nums.Take(exchangeIndex).ToList();
            var secondHalf = nums.Skip(exchangeIndex).ToList();
            nums = new List<long>();
            nums.AddRange(secondHalf);
            nums.AddRange(firstHalf);
            return false;
        }
    }
}
