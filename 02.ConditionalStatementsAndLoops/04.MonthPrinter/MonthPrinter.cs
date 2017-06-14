using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MonthPrinter
{
    class MonthPrinter
    {
        static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());
            string[] array = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            if (month >= 1 && month <= 12)
            {
                Console.WriteLine(array[month - 1]);
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
