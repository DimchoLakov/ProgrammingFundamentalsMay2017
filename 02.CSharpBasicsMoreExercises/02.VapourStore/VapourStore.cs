using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VapourStore
{
    class VapourStore
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double outFall4 = 39.99;
            double csOg = 15.99;
            double zplinterZell = 19.99;
            double honoredTwo = 59.99;
            double roverWatch = 29.99;
            double roverWatchOrigins = 39.99;
            double sum = 0.0d;            

            while (true)
            {
                string games = Console.ReadLine();
                if (games == "OutFall 4")
                {
                    if (outFall4 > currentBalance)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought OutFall 4");
                        currentBalance -= outFall4;
                        sum += outFall4;
                    }                    
                }
                else if (games == "CS: OG")
                {
                    if (csOg > currentBalance)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought CS: OG");
                        currentBalance -= csOg;
                        sum += csOg;
                    }                    
                }
                else if (games == "Zplinter Zell")
                {
                    if (zplinterZell > currentBalance)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought Zplinter Zell");
                        currentBalance -= zplinterZell;
                        sum += zplinterZell;
                    }                    
                }
                else if (games == "Honored 2")
                {
                    if (honoredTwo > currentBalance)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought Honored 2");
                        currentBalance -= honoredTwo;
                        sum += honoredTwo;
                    }                    
                }
                else if (games == "RoverWatch")
                {
                    if (roverWatch > currentBalance)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought RoverWatch");
                        currentBalance -= roverWatch;
                        sum += roverWatch;
                    }                    
                }
                else if (games == "RoverWatch Origins Edition")
                {
                    if (roverWatchOrigins > currentBalance)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        Console.WriteLine($"Bought RoverWatch Origins Edition");
                        currentBalance -= roverWatchOrigins;
                        sum += roverWatchOrigins;
                    }                    
                }
                else if (games == "Game Time")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
            }
            if (currentBalance != 0)
            {
                Console.WriteLine($"Total spent: ${sum:f2}. Remaining: ${currentBalance:f2}");
            }            
        }
    }
}
