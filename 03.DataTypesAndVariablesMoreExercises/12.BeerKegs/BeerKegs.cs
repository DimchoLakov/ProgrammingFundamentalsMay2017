using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.BeerKegs
{
    class BeerKegs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string biggestKegModel = null;
            double biggestKeg = 0d;
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double formula = Math.PI * radius * radius * height;
                if (formula > biggestKeg)
                {
                    biggestKeg = formula;
                    biggestKegModel = model;
                }
            }
            Console.WriteLine(biggestKegModel);
        }
    }
}
