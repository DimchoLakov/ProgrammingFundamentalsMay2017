using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RefactorSpecialNumbers
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int num = 1; num <= n; num++)
            {
                sum = num / 10 + num % 10;
                bool isTrue = sum == 5 || sum == 7 || sum == 11;
                if (sum == 5 || sum == 7 || sum == 11);               
                {
                    Console.WriteLine($"{num} -> {isTrue}");
                }
            }
        }
    }
}
