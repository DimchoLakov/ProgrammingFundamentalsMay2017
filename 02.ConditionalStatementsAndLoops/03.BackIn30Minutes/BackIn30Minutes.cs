using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BackIn30Minutes
{
    class BackIn30Minutes
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;
            int counter = 0;
            for (int i = 0; i < hours; i+=24)
            {
                counter++;
            } 
            if (minutes >= 60)
            {
                minutes -= 60;
                hours++;
            }            
            if (hours >= 24)
            {
                hours = hours / counter;
                hours %= 24;
            }
            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
