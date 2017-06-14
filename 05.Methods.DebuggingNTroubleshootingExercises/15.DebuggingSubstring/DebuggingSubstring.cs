using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.DebuggingSubstring
{
    class DebuggingSubstring
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            char letterP = 'p';
            bool hasMatch = false;
             
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == letterP)
                {
                    text = text.ToString();
                    hasMatch = true;
                    int endIndex = jump + i;

                    if (endIndex > text.Length - 1)
                    {
                        endIndex = text.Length - 1;
                    }
                    string matchedString = text.Substring(i, endIndex - i + 1);
                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
