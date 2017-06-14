using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());            
            double studio = 0.0d;
            double Double = 0.0d;
            double suite = 0.0d;

            if (month == "May" || month == "October")
            {
                studio = 50;
                Double = 65;
                suite = 75;
            }
            else if (month == "June" || month == "September")
            {
                studio = 60;
                Double = 72;
                suite = 82;
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studio = 68;
                Double = 77;
                suite = 89;
            }

            
            double priceStudio = studio * nights;
            double priceDouble = Double * nights;
            double priceSuite = suite * nights;

            if (nights > 7 && nights <= 14)
            {
                if (month == "September")
                {
                    priceStudio = priceStudio - 60;
                }
                else if (month == "October")
                {
                    priceStudio = priceStudio - 50;
                }
                if (month == "May" || month == "October")
                {
                    priceStudio -= priceStudio * 0.05;
                }
            }
            else if (nights > 14)
            {
                if (month == "June" || month == "September")
                {
                    priceDouble -= priceDouble * 0.1;
                }
                else if (month == "July" || month == "August" || month == "December")
                {
                    priceSuite -= priceSuite * 0.15;
                }
            }

            Console.WriteLine($"Studio: {priceStudio:f2} lv.\nDouble: {priceDouble:f2} lv.\nSuite: {priceSuite:f2} lv.");
        }
    }
}
