using System;
using System.Runtime.CompilerServices;

namespace _03.IntersectionOfCircles
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
    }

    class Circle
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Radius { get; set; }

        public static Circle Parse(double x, double y, double radius)
        {
            Circle circle = new Circle
            {
                X = x,
                Y = y,
                Radius = radius
            };
            return circle;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle firstCircle = ReadCircle();
            Circle secondCircle = ReadCircle();

            Point firstCentre = Point.ParsePoint(firstCircle.X, firstCircle.Y);
            Point secondCentre = Point.ParsePoint(secondCircle.X, secondCircle.Y);

            double distanceBetweenRadiuses = FindEuclideanDistance(firstCentre, secondCentre);

            if (distanceBetweenRadiuses <= firstCircle.Radius + secondCircle.Radius)
            {
                Console.WriteLine($"Yes");
            }
            else
            {
                Console.WriteLine($"No");
            }

        }

        public static Circle ReadCircle()
        {
            string[] tokens = Console.ReadLine().Split(' ');
            double x = double.Parse(tokens[0]);
            double y = double.Parse(tokens[1]);
            double radius = double.Parse(tokens[2]);

            return Circle.Parse(x, y, radius);
        }

        public static double FindEuclideanDistance(Point firstPoint, Point secondPoint)
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
