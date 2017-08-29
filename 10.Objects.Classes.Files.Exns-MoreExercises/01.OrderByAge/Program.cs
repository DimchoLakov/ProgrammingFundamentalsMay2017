using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.OrderByAge
{
    class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public static Person Parse(string name, string id, int age)
        {
            return new Person
            {
                Name = name,
                Id = id,
                Age = age
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Person> people = new List<Person>();

            while (input != "End")
            {
                string[] tokens = input.Split(' ');

                string name = tokens[0];
                string id = tokens[1];
                int age = int.Parse(tokens[2]);

                people.Add(Person.Parse(name, id, age));

                input = Console.ReadLine();
            }

            foreach (Person person in people.OrderBy(a => a.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
}
