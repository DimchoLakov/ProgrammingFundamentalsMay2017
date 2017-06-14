using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ManipulateArray
{
    class ManipulateArray
    {
        static void Main(string[] args)
        {
            string[] myArray = Console.ReadLine().Split(' ').ToArray();
            int commandCounter = int.Parse(Console.ReadLine());            
            for (int i = 0; i < commandCounter; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ').ToArray();
                string command = tokens[0];
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
                        string newWord = tokens[2];
                        myArray[index] = newWord;
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", myArray));
        }
    }
}
