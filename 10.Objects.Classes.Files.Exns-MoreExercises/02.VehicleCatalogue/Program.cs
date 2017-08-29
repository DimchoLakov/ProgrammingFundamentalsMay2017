using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;

namespace _02.VehicleCatalogue
{
    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public static Vehicle Parse(string type, string model, string color, int horsePower)
        {
            return new Vehicle
            {
                Type = type,
                Model = model,
                Color = color,
                HorsePower = horsePower
            };
        }

        public void Brum()
        {
            Console.WriteLine($" {Model} Brrrrum");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Vehicle> catalogue = new List<Vehicle>();

            while (input != "End")
            {
                string[] tokens = input.Split(' ');

                string type = tokens[0];
                type = type.Substring(0, 1).ToUpper() + type.Substring(1, type.Length - 1).ToLower();
                string model = tokens[1];
                string color = tokens[2];
                int horsePower = int.Parse(tokens[3]);

                Vehicle vehicle = Vehicle.Parse(type, model, color, horsePower);

                catalogue.Add(vehicle);

                input = Console.ReadLine();
            }

            string modelInput = Console.ReadLine();

            while (modelInput != "Close the Catalogue")
            {
                if (catalogue.Exists(m => m.Model == modelInput))
                {
                    int index = catalogue.FindIndex(m => m.Model == modelInput);
                    Console.WriteLine($"Type: {catalogue[index].Type}");
                    Console.WriteLine($"Model: {catalogue[index].Model}");
                    Console.WriteLine($"Color: {catalogue[index].Color}");
                    Console.WriteLine($"Horsepower: {catalogue[index].HorsePower}");
                }
                modelInput = Console.ReadLine();
            }
            double carsAverageHorsePower = 0d;
            double trucksAverageHorsePower = 0d;

            try
            {
                carsAverageHorsePower = catalogue.Where(c => c.Type == "Car").Average(h => h.HorsePower);
                Console.WriteLine($"Cars have average horsepower of: {carsAverageHorsePower:f2}.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Cars have average horsepower of: {carsAverageHorsePower:f2}.");
            }

            try
            {
                trucksAverageHorsePower = catalogue.Where(c => c.Type == "Truck").Average(h => h.HorsePower);
                Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHorsePower:f2}.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHorsePower:f2}.");
            }

        }
    }
}
