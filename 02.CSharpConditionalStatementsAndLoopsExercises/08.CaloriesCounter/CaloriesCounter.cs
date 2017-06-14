using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CaloriesCounter
{
    class CaloriesCounter
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cheese = 500;
            int tomatoSauce = 150;
            int salami = 600;
            int pepper = 50;
            int calories = 0;
            for (int i = 1; i <= n; i++)
            {
                string ingredients = Console.ReadLine().ToLower();
                if (ingredients == "cheese")
                {
                    calories += cheese;
                }
                else if (ingredients == "tomato sauce")
                {
                    calories += tomatoSauce;
                }
                else if (ingredients == "salami")
                {
                    calories += salami;
                }
                else if (ingredients == "pepper")
                {
                    calories += pepper;
                }
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
