using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.DecryptingMessages
{
    class DecryptingMessages
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberOfLines = int.Parse(Console.ReadLine());
            int decryption = 0;
            for (int i = 1; i <= numberOfLines; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                decryption = symbol + key;
                Console.Write((char)decryption);
            }
        }
    }
}
