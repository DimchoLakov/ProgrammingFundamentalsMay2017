using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PlayCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int exceptions = 0;

            while (exceptions < 3)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                string command = tokens[0];

                switch (command)
                {
                    case "Replace":
                        try
                        {
                            int index = int.Parse(tokens[1]);
                            int element = int.Parse(tokens[2]);
                            nums[index] = element;
                        }
                        catch (Exception)
                        {
                            int tempIndex;
                            int tempElement;
                            if (int.TryParse(tokens[1], out tempIndex) && int.TryParse(tokens[2], out tempElement))
                            {
                                Console.WriteLine($"The index does not exist!");
                                exceptions++;
                            }
                            else
                            {
                                Console.WriteLine($"The variable is not in the correct format!");
                                exceptions++;
                            }
                        }
                        break;
                    case "Print":
                        try
                        {
                            int startIndex = int.Parse(tokens[1]);
                            int endIndex = int.Parse(tokens[2]);
                            Console.WriteLine(string.Join(", ", nums.GetRange(startIndex, endIndex - startIndex + 1)));
                        }
                        catch (Exception)
                        {
                            int tempStartIndex;
                            int tempEndIndex;
                            try
                            {
                                if (int.TryParse(tokens[1], out tempStartIndex) && int.TryParse(tokens[2], out tempEndIndex))
                                {
                                    Console.WriteLine($"The index does not exist!");
                                    exceptions++;
                                }
                                else
                                {
                                    Console.WriteLine($"The variable is not in the correct format!");
                                    exceptions++;
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine($"The index does not exist!");
                                exceptions++;
                            }
                        }
                        break;
                    case "Show":
                        try
                        {
                            int showIndex = int.Parse(tokens[1]);
                            Console.WriteLine(nums[showIndex]);
                        }
                        catch (Exception)
                        {
                            int tempShowIndex;
                            if (int.TryParse(tokens[1], out tempShowIndex))
                            {
                                Console.WriteLine($"The index does not exist!");
                                exceptions++;
                            }
                            else
                            {
                                Console.WriteLine($"The variable is not in the correct format!");
                                exceptions++;
                            }
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", nums));
        }
        
    }
}
