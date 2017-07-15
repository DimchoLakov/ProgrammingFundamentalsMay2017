using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace _07.TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] charArr = input.ToCharArray();

            List<int> digitsArr = new List<int>();
            List<char> nonDigitArr = new List<char>();

            for (int i = 0; i < charArr.Length; i++)
            {
                if (char.IsDigit(charArr[i]))
                {
                    digitsArr.Add(charArr[i] - '0');
                }
                else
                {
                    nonDigitArr.Add(charArr[i]);
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < digitsArr.Count; i++)
            {
                if (i % 2 != 0)
                {
                    skipList.Add(digitsArr[i]);
                }
                else
                {
                    takeList.Add(digitsArr[i]);
                }
            }

            string result = string.Empty;
           
            int totalSkip = 0;

            for (int j = 0; j < skipList.Count; j++)
            {
                int skipCount = skipList[j];
                int takeCount = takeList[j];
                result += new string(nonDigitArr.Skip(totalSkip).Take(takeCount).ToArray());
                totalSkip += skipCount + takeCount;
            }
            Console.WriteLine(result);
        }
    }
}
