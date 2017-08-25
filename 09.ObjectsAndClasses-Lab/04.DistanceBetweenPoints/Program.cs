using System;
using System.Linq;

namespace _04.DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstPoint = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondPoint = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            double distance = FindEuclideanDistance(firstPoint, secondPoint);
            Console.WriteLine($"{distance:f3}");
        }

        static double FindEuclideanDistance(int[] firstPoint, int[] secondPoint)
        {
            int x1 = firstPoint[0];
            int y1 = firstPoint[1];
            int x2 = secondPoint[0];
            int y2 = secondPoint[1];

            double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            return distance;
        }
    }
}
