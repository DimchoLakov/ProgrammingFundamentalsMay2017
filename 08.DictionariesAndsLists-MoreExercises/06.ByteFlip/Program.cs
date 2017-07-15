using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _06.ByteFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Where(x => x.Length == 2).ToArray();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                char[] charArray = input[i].ToCharArray();
                Array.Reverse(charArray);
                Console.Write(System.Convert.ToChar(System.Convert.ToUInt32(new string(charArray), 16)));
            }
            Console.WriteLine();
        }
    }
}
