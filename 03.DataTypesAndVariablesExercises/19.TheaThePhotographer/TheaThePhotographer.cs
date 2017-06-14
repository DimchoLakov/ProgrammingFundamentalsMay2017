using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TheaThePhotographer
{
    class TheaThePhotographer
    {
        static void Main(string[] args)
        {
            int numberOfPictures = int.Parse(Console.ReadLine());
            int filterTimeInSeconds = int.Parse(Console.ReadLine());
            int percentageOfPicturesToUpload = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());
            checked // check if there is overflow arithmetics
            {
                long goodPictures = (long)(Math.Ceiling(numberOfPictures * (percentageOfPicturesToUpload / 100d)));
                long allFilteredPics = (long)numberOfPictures * filterTimeInSeconds;
                long allGoodFilteredPics = (long)(goodPictures * uploadTime);
                long totalTimeInSeconds = allFilteredPics + allGoodFilteredPics;

                TimeSpan timeNeeded = TimeSpan.FromSeconds(totalTimeInSeconds);
                Console.WriteLine(timeNeeded.ToString(@"d\:hh\:mm\:ss"));
            }
        }
    }
}