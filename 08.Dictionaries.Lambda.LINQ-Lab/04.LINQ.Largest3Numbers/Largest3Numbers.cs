﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LINQ.Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).OrderByDescending(x => x).Take(3).ToList();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
