using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;

namespace _03.Jarvis
{
    class Robot
    {
        public List<Arms> Arms { get; set; }
        public List<Legs> Legs { get; set; }
        public List<Torso> Torso { get; set; }
        public List<Head> Head { get; set; }

    }
    class Arms
    {
        public long Energy { get; set; }
        public int Reach { get; set; }
        public int FingersCount { get; set; }

        public static Arms Parse(long energy, int reach, int fingersCount)
        {
            return new Arms
            {
                Energy = energy,
                Reach = reach,
                FingersCount = fingersCount
            };
        }
    }
    class Legs
    {
        public long Energy { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
        public static Legs Parse(long energy, int strength, int speed)
        {
            return new Legs
            {
                Energy = energy,
                Strength = strength,
                Speed = speed
            };
        }
    }
    class Torso
    {
        public long Energy { get; set; }
        public double Size { get; set; }
        public string HousingMaterial { get; set; }
        public static Torso Parse(long energy, double size, string housingMaterial)
        {
            return new Torso
            {
                Energy = energy,
                Size = size,
                HousingMaterial = housingMaterial
            };
        }
    }
    class Head
    {
        public long Energy { get; set; }
        public int Iq { get; set; }
        public string SkinMaterial { get; set; }
        public static Head Parse(long energy, int iq, string skinMaterial)
        {
            return new Head
            {
                Energy = energy,
                Iq = iq,
                SkinMaterial = skinMaterial
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            long energyCapacity = long.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            Robot jarvis = new Robot();
            jarvis.Arms = new List<Arms>();
            jarvis.Legs = new List<Legs>();
            jarvis.Head = new List<Head>();
            jarvis.Torso = new List<Torso>();

            while (input != "Assemble!")
            {
                string[] tokens = input.Split(' ');

                string type = tokens[0];
                long energyConsumption = long.Parse(tokens[1]);
                string firstProperty = tokens[2];
                string secondProperty = tokens[3];

                CreateJarvisRobot(type, energyConsumption, firstProperty, secondProperty, jarvis);


                input = Console.ReadLine();
            }

            if (jarvis.Arms.Count >= 2 && jarvis.Legs.Count >= 2 && jarvis.Head.Count > 0 && jarvis.Torso.Count > 0)
            {
                long consumedEnergy = jarvis.Arms.OrderBy(e => e.Energy).First().Energy
                    + jarvis.Arms.OrderBy(e => e.Energy).Skip(1).First().Energy
                    + jarvis.Legs.OrderBy(e => e.Energy).First().Energy
                    + jarvis.Legs.OrderBy(e => e.Energy).Skip(1).First().Energy
                    + jarvis.Head.OrderBy(e => e.Energy).First().Energy
                    + jarvis.Torso.OrderBy(e => e.Energy).First().Energy;

                if (consumedEnergy > energyCapacity)
                {
                    Console.WriteLine($"We need more power!");
                }
                else
                {
                    PrintRobotParts(jarvis);
                }
            }
            else
            {
                Console.WriteLine($"We need more parts!");
            }
        }

        static void PrintRobotParts(Robot jarvis)
        {
            Console.WriteLine($"Jarvis:");
            Console.WriteLine($"#Head:");
            foreach (Head head in jarvis.Head.OrderBy(e => e.Energy).Take(1))
            {
                Console.WriteLine($"###Energy consumption: {head.Energy}");
                Console.WriteLine($"###IQ: {head.Iq}");
                Console.WriteLine($"###Skin material: {head.SkinMaterial}");
            }

            Console.WriteLine($"#Torso:");
            foreach (Torso torso in jarvis.Torso.OrderBy(e => e.Energy).Take(1))
            {
                Console.WriteLine($"###Energy consumption: {torso.Energy}");
                Console.WriteLine($"###Processor size: {torso.Size:f1}");
                Console.WriteLine($"###Corpus material: {torso.HousingMaterial}");
            }
            
            foreach (Arms arm in jarvis.Arms.OrderBy(e => e.Energy).Take(2))
            {
                Console.WriteLine($"#Arm:");
                Console.WriteLine($"###Energy consumption: {arm.Energy}");
                Console.WriteLine($"###Reach: {arm.Reach}");
                Console.WriteLine($"###Fingers: {arm.FingersCount}");
            }
            
            foreach (Legs leg in jarvis.Legs.OrderBy(e => e.Energy).Take(2))
            {
                Console.WriteLine($"#Leg:");
                Console.WriteLine($"###Energy consumption: {leg.Energy}");
                Console.WriteLine($"###Strength: {leg.Strength}");
                Console.WriteLine($"###Speed: {leg.Speed}");
            }
        }

        static void CreateJarvisRobot(string type, long energyConsumption, string firstProp, string secondProp,
            Robot jarvis)
        {
            double torsoFirstProperty = double.Parse(firstProp);
            int firstProperty = int.Parse(firstProp);

            switch (type)
            {

                case "Arm":

                    Arms arm = Arms.Parse(energyConsumption, firstProperty, int.Parse(secondProp));
                    jarvis.Arms.Add(arm);

                    break;
                case "Leg":

                    Legs leg = Legs.Parse(energyConsumption, firstProperty, int.Parse(secondProp));
                    jarvis.Legs.Add(leg);

                    break;
                case "Head":

                    Head head = Head.Parse(energyConsumption, firstProperty, secondProp);
                    jarvis.Head.Add(head);

                    break;
                case "Torso":
                    Torso torso = Torso.Parse(energyConsumption, torsoFirstProperty, secondProp);
                    jarvis.Torso.Add(torso);

                    break;
            }
        }
    }
}
