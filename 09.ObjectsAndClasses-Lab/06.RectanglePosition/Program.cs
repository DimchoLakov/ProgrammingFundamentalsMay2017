using System;
using System.Linq;
using System.Security.AccessControl;

namespace _06.RectanglePosition
{
    class Rectangle
    {
        public double Left { get; set; }
        public double Top { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public double Right
        {
            get
            {
                return Left + Width;
            }
        }

        public double Bottom {
            get
            {
                return Top + Height;
            }
        }
        public double CalcArea()
        {
            return Height * Width;
        }

        public bool IsInside(Rectangle rectangle)
        {
            var isLeftValid = rectangle.Left <= Left;
            var isTopValid = rectangle.Top <= Top;
            var isRightValid = rectangle.Right >= Right;
            var isBottomValid = rectangle.Bottom >= Bottom;

            return isLeftValid && isTopValid && isRightValid && isBottomValid;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle firstRectangle = ReadRectangle();
            Rectangle secondRectangle = ReadRectangle();

            bool result = firstRectangle.IsInside(secondRectangle);

            if (result)
            {
                Console.WriteLine($"Inside");
            }
            else
            {
                Console.WriteLine($"Not inside");
            }

        }

        public static Rectangle ReadRectangle()
        {
            double[] rectangleParts = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Rectangle rect = new Rectangle
            {
                Left = rectangleParts[0],
                Top = rectangleParts[1],
                Width = rectangleParts[2],
                Height = rectangleParts[3]
            };
            return rect;
        }

    }
}
