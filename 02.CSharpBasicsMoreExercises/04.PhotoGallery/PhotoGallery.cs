using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;


namespace _04.PhotoGallery
{
    class PhotoGallery
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string sizeType = null;
            string orientation = null;
            double realSize = 0.0d;

            if (size > 0 && size < 1000)
            {
                realSize = size;
                sizeType = "B";
            }
            else if (size >= 1000 && size < 999999)
            {
                realSize = size / 1000;
                sizeType = "KB";
            }
            else if (size >= 1000000)
            {
                realSize = size / 1000000.0;
                sizeType = "MB";
            }

            if (width > height)
            {
                orientation = "landscape";
            }
            else if (width < height)
            {
                orientation = "portrait";
            }
            else if (width == height)
            {
                orientation = "square";
            }

            DateTime date = new DateTime(year, month, day, hours, minutes, 0);

            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
            Console.WriteLine($"Date Taken: {date.ToString("dd/MM/yyyy HH:mm")}");
            Console.WriteLine($"Size: {realSize}{sizeType}");
            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");
        }
    }
}
