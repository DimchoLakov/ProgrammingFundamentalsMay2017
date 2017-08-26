using System;
using System.Globalization;
using System.Linq;

namespace _01.CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            string startDate = Console.ReadLine();
            string endDate = Console.ReadLine();

            DateTime firstDate = DateTime.ParseExact(startDate, $"dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(endDate, $"dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] holidays = new DateTime[12];

            holidays[0] = new DateTime(8, 01, 01);
            holidays[1] = new DateTime(8, 03, 03);
            holidays[2] = new DateTime(8, 05, 01);
            holidays[3] = new DateTime(8, 05, 06);
            holidays[4] = new DateTime(8, 05, 24);
            holidays[5] = new DateTime(8, 09, 06);
            holidays[6] = new DateTime(8, 09, 22);
            holidays[7] = new DateTime(8, 11, 01);
            holidays[9] = new DateTime(8, 12, 24);
            holidays[10] = new DateTime(8, 12, 25);
            holidays[11] = new DateTime(8, 12, 26);

            int workingDays = 0;

            for (DateTime i = firstDate; i <= secondDate; i = i.AddDays(1))
            {
                DateTime tempDate = new DateTime(8, i.Month, i.Day);
                if (!i.DayOfWeek.Equals(DayOfWeek.Saturday) && !i.DayOfWeek.Equals(DayOfWeek.Sunday) && !holidays.Contains(tempDate))
                {
                    workingDays++;
                }
            }
           
            Console.WriteLine(workingDays);
        }
    }
}
