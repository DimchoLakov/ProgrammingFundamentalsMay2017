using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SmsTyping
{
    class SmsTyping
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            string[] letters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string text = "";

            for (int i = 0; i < n; i++)
            {
                int keyboardKeys = int.Parse(Console.ReadLine());

                if (keyboardKeys != 0)
                {
                    int digitLenght = keyboardKeys.ToString().Length;
                    int mainDigit = keyboardKeys % 10;
                    int offset = (mainDigit - 2) * 3;
                   if (mainDigit == 8 || mainDigit == 9)
                   {
                       offset++;
                   }
                    int letterIndex = offset + digitLenght - 1;

                    text += letters[letterIndex];
                }
                else
                {
                    text += " ";
                }
            }
            Console.WriteLine(text);
        }
    }
}
