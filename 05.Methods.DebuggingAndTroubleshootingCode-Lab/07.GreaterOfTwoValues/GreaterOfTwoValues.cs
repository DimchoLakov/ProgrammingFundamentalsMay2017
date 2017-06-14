using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                GetMax(first, second);
            }
            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                GetMax(first, second);
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                GetMax(first, second);
            }
        }

        static string GetMax(string first, string second)
        {
            string bigger = null;
            if (first.CompareTo(second) >= 0)
            {
                bigger = first;
            }
            else
            {
                bigger = second;
            }
            Console.WriteLine(bigger);
            return bigger;
        }

        static int GetMax(int first, int second)
        {
            int result = Math.Max(first, second);
            Console.WriteLine(result);
            return result;
            
        }

        static char GetMax(char first, char second)
        {
            int result = Math.Max(first, second);
            Console.WriteLine((char)result);
            return (char)result;
        }
    }
}
