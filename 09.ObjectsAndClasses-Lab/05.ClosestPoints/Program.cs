using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ClosestPoints
{
    class Point
    {
        public double PointX { get; set; }
        public double PointY { get; set; }

        public static Point ParsePoint(double x, double y)
        {
            Point newPoint = new Point
            {
                PointX = x,
                PointY = y
            };
            return newPoint;
        }

        public static string Print(Point point)
        {
            string result = $"({point.PointX}, {point.PointY})";
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Point> allPoints = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                double[] pointsInput = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
                double x = pointsInput[0];
                double y = pointsInput[1];
                allPoints.Add(Point.ParsePoint(x, y));
            }

            double smallestDistance = double.MaxValue;
            Point pointOne = null;
            Point pointTwo = null;

            for (int first = 0; first < allPoints.Count; first++)
            {
                for (int second = first + 1; second < allPoints.Count; second++)
                {
                    double currentDistance = FindEuclideanDistance(allPoints[first], allPoints[second]);

                    if (currentDistance < smallestDistance)
                    {
                        smallestDistance = currentDistance;
                        pointOne = allPoints[first];
                        pointTwo = allPoints[second];
                    }
                }
            }

            PrintPoints(smallestDistance, pointOne, pointTwo);
        }

        private static void PrintPoints(double smallestDistance, Point pointOne, Point pointTwo)
        {
            Console.WriteLine($"{smallestDistance:f3}");
            Console.WriteLine(Point.Print(pointOne));
            Console.WriteLine(Point.Print(pointTwo));
        }

        private static double FindEuclideanDistance(Point firstPoint, Point secondPoint)
        {
            double x1 = firstPoint.PointX;
            double y1 = firstPoint.PointY;
            double x2 = secondPoint.PointX;
            double y2 = secondPoint.PointY;

            double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            return distance;
        }
    }
}
