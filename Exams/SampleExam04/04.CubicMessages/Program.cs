using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.CubicMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"^(?<before>\d+)(?<message>([A-Za-z]+))(?<after>[^A-Za-z]*)$";

            while (input != "Over!")
            {
                int messageLength = int.Parse(Console.ReadLine());
                Regex cubic = new Regex(pattern);
                Match match = cubic.Match(input);

                if (match.Groups["message"].Length == messageLength)
                {
                    string content = match.Groups["message"].Value;

                    char[] firstDigits = match.Groups["before"].Value.ToCharArray();
                    string firstSplit = string.Join(" ", firstDigits);
                    int[] startDigits = firstSplit.Split(' ').Select(int.Parse).ToArray();

                    char[] arrEnd = match.Groups["after"].Value.ToCharArray();
                    char[] lastDigits = arrEnd.Where(x => char.IsDigit(x)).ToArray();
                    string secondSplit = string.Join(" ", lastDigits);
                    int[] endDigits = new int[lastDigits.Length];
                    if (lastDigits.Length > 0)
                    {
                        endDigits = secondSplit.Split(' ').Select(int.Parse).ToArray();
                    }

                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < startDigits.Length; i++)
                    {
                        if (startDigits[i] >= 0 && startDigits[i] < content.Length)
                        {
                            sb.Append(content[startDigits[i]]);
                        }
                        else
                        {
                            sb.Append(' ');
                        }
                    }

                    for (int i = 0; i < endDigits.Length; i++)
                    {
                        if (endDigits[i] >= 0 && endDigits[i] < content.Length)
                        {
                            sb.Append(content[endDigits[i]]);
                        }
                        else
                        {
                            sb.Append(' ');
                        }
                    }
                    if (sb.Length > 0)
                    {
                        Console.WriteLine($"{content} == {sb.ToString()}");
                    }
                }
                input = Console.ReadLine();
            }

        }
    }
}
