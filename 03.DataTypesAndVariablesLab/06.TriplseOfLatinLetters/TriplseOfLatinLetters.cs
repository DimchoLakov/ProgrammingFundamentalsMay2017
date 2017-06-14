using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TriplseOfLatinLetters
{
    class TriplseOfLatinLetters
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (char firstLetter = 'a'; firstLetter <= (n - 1) + 'a'; firstLetter++)
            {
                for (char secondLetter = 'a'; secondLetter <= (n - 1) + 'a'; secondLetter++)
                {
                    for (char thirdLetter = 'a'; thirdLetter <= (n - 1) + 'a'; thirdLetter++)
                    {
                        Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");
                    }
                }
            }
        }
    }
}
