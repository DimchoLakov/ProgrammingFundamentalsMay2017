using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.PizzaIngredients
{
    class PizzaIngredients
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split(' ');
            string[] totalIngredients = new string[ingredients.Length];

            int lengthOfStrings = int.Parse(Console.ReadLine());
            int ingredientsCounter = 0;

            for (int i = 0; i < ingredients.Length; i++)
            {                
                if (ingredients[i].Length == lengthOfStrings)
                {
                    Console.WriteLine($"Adding {ingredients[i]}.");
                    totalIngredients[i] += ingredients[i];
                    ingredientsCounter++;
                }
                if (ingredientsCounter >= 10)
                {
                    break;
                }
            }
            totalIngredients = totalIngredients.Where(s => !String.IsNullOrEmpty(s)).ToArray();
            Console.WriteLine($"Made pizza with total of {ingredientsCounter} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", totalIngredients)}.");
        }
    }
}
