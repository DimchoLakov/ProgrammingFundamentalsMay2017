using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SafeManipulation
{
    class SafeManipulation
    {
        static void Main(string[] args)
        {
            string[] myArray = Console.ReadLine().Split(' ').ToArray();
            while (true)
            {
                string[] tokens = Console.ReadLine().Split(' ').ToArray();
                string command = tokens[0];
                if (command == "END")
                {
                    break;
                }
                switch (command)
                {
                    case "Reverse":
                        Array.Reverse(myArray);
                        break;
                    case "Distinct":
                        myArray = myArray.Distinct().ToArray();
                        break;
                    case "Replace":
                        int index = int.Parse(tokens[1]);
                        if (index < 0 || index > myArray.Length - 1)
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        else
                        {
                            string newWord = tokens[2];
                            myArray[index] = newWord;
                        }                        
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", myArray));
        }
    }
}
