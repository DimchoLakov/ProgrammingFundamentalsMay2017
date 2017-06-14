using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DNASequences
{
    class DNASequences
    {

        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int counter = 0;
            string firstLetter = null;
            string secondsLetter = null;
            string thirdLetter = null;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k ++)
                    {
                        counter++;
                        switch (i)
                        {
                            case 1:
                                firstLetter = "A";
                                break;
                            case 2:
                                firstLetter = "C";
                                break;
                            case 3:
                                firstLetter = "G";
                                break;
                            case 4:
                                firstLetter = "T";
                                break;
                        }
                        switch (j)
                        {
                            case 1:
                                secondsLetter = "A";
                                break;
                            case 2:
                                secondsLetter = "C";
                                break;
                            case 3:
                                secondsLetter = "G";
                                break;
                            case 4:
                                secondsLetter = "T";
                                break;
                        }
                        switch (k)
                        {
                            case 1:
                                thirdLetter = "A";
                                break;
                            case 2:
                                thirdLetter = "C";
                                break;
                            case 3:
                                thirdLetter = "G";
                                break;
                            case 4:
                                thirdLetter = "T";
                                break;
                        }
                        if (i + j + k >= sum)
                        {
                            Console.Write($"O{firstLetter}{secondsLetter}{thirdLetter}O ");
                        }
                        else
                        {
                            Console.Write($"X{firstLetter}{secondsLetter}{thirdLetter}X ");
                        }
                        if (counter % 4 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
