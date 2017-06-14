using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaxMethod
{
    class MaxMethod
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int maxOfFirstAndSecond = GetMax(firstNum, secondNum);
            int maximum = GetMax(maxOfFirstAndSecond, thirdNum);
            Console.WriteLine(maximum);
        }
        
        static int GetMax(int firstNum, int secondNum)
        {
            int max = Math.Max(firstNum, secondNum);
            return max;
        }
    }
}
