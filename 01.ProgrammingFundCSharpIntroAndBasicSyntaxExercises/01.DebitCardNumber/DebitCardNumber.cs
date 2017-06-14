using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitCardNumber
{
    class DebitCardNumber
    {
        static void Main(string[] args)
        {
            int firstFour = int.Parse(Console.ReadLine());
            int secondFour = int.Parse(Console.ReadLine());
            int thirdFour = int.Parse(Console.ReadLine());
            int fourthFour = int.Parse(Console.ReadLine());
            Console.WriteLine($"{firstFour:D4} {secondFour:D4} {thirdFour:D4} {fourthFour:D4}");
        }
    }
}
