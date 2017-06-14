using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseArrayFromStrings
{
    class ReverseArrayFromStrings
    {
        static void Main(string[] args)
        {
            string[] myArray = Console.ReadLine().Split(' ');
            string[] reversed = new string[myArray.Length];
            for (int start = 0; start < myArray.Length; start++)
            {
                reversed[start] = myArray[myArray.Length - 1 - start];
            }
            Console.WriteLine(string.Join(" ", reversed));
        }
    }
}
