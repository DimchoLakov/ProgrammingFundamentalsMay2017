using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            switch (figure)
            {
                case "triangle":
                    double triangleSide = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    double triangleArea = GetTriangleArea(triangleSide, height);
                    Console.WriteLine(Math.Round(triangleArea, 2));
                    break;
                case "square":
                    double squareSide = double.Parse(Console.ReadLine());
                    double squareArea = GetSquareArea(squareSide);
                    Console.WriteLine(Math.Round(squareArea, 2));
                    break;
                case "rectangle":
                    double rectangleWidth = double.Parse(Console.ReadLine());
                    double rectangleHeight = double.Parse(Console.ReadLine());
                    double rectangleArea = GetRectangleArea(rectangleWidth, rectangleHeight);
                    Console.WriteLine(Math.Round(rectangleArea, 2));
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    double circleArea = GetCircleArea(radius);
                    Console.WriteLine(Math.Round(circleArea, 2));
                    break;
                default:
                    break;
            }
        }

        static double GetCircleArea(double radius)
        {
            double area = Math.Pow(radius, 2) * Math.PI;
            return area;
        }

        static double GetRectangleArea(double rectangleWidth, double rectangleHeight)
        {
            double area = rectangleWidth * rectangleHeight;
            return area;
        }

        static double GetSquareArea(double squareSide)
        {
            double area = squareSide * squareSide;
            return area;
        }

        static double GetTriangleArea(double triangleSide, double height)
        {
            double area = triangleSide * height / 2;
            return area;
        }
    }
}
