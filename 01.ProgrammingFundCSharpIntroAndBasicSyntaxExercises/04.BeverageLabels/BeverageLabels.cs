using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BeverageLabels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            string drinkName = Console.ReadLine();
            int ml = int.Parse(Console.ReadLine());
            int kCalPer100Ml = int.Parse(Console.ReadLine());
            int sugarsPer100Ml = int.Parse(Console.ReadLine());
            double kCal = ml * (kCalPer100Ml / 100.0);
            double sugars = ml * (sugarsPer100Ml / 100d);
            Console.WriteLine($"{ml}ml {drinkName}:\n{kCal}kcal, {sugars}g sugars");
        }
    }
}
