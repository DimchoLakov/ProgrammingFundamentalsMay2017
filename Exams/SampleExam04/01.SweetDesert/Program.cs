using System;
using System.Xml;

namespace _01.SweetDesert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cashIvancho = decimal.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            decimal banannasPrice = decimal.Parse(Console.ReadLine()) * 2;
            decimal eggsPrice = decimal.Parse(Console.ReadLine()) * 4;
            decimal berriesForKiloPrice = decimal.Parse(Console.ReadLine()) * 0.2m;

            int sets = 0;
            if (guests % 6 == 0)
            {
                sets = guests / 6;
            }
            else
            {
                sets = guests / 6 + 1;
            }

            decimal totalPrice = (banannasPrice * sets) + (eggsPrice * sets) + (berriesForKiloPrice * sets);
            decimal diff = Math.Abs(totalPrice - cashIvancho);
            if (totalPrice <= cashIvancho)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {diff:f2}lv more.");
            }

        }
    }
}
