using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CubeProperties
{
    class CubeProperties
    {
        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            if (parameter == "face")
            {
                double face = GetFaceDiagonals(cubeSide);
                Console.WriteLine($"{Math.Round(face, 2)}");
            }
            else if (parameter == "space")
            {
                double space = GetSpaceDiagonals(cubeSide);
                Console.WriteLine($"{Math.Round(space, 2)}");
            }
            else if (parameter == "volume")
            {
                double volume = GetVolume(cubeSide);
                Console.WriteLine($"{Math.Round(volume, 2)}");
            }
            else if (parameter == "area")
            {
                double area = GetSurfaceArea(cubeSide);
                Console.WriteLine($"{Math.Round(area, 2)}");
            }
        }

        static double GetSurfaceArea(double cubeSide)
        {
            double surfaceArea = 6d * Math.Pow(cubeSide, 2);
            return surfaceArea;
        }

        static double GetVolume(double cubeSide)
        {
            double volume = Math.Pow(cubeSide, 3);
            return volume;
        }

        static double GetSpaceDiagonals(double cubeSide)
        {
            double spaceDiagonal = Math.Sqrt(3 * Math.Pow(cubeSide, 2));
            return spaceDiagonal;
        }

        static double GetFaceDiagonals(double cubeSide)
        {
            double faceDiagonal = Math.Sqrt(2 * Math.Pow(cubeSide, 2));
            return faceDiagonal;
        }
    }
}
