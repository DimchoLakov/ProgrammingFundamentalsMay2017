using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HelloName
{
    class HelloName
    {
        static void Main(string[] args)
        {
            PrintName(Console.ReadLine());
        }
        
        static string PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
            return name;
        }
    }
}
