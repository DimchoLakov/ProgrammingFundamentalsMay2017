using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace _10.StudentGroups
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegisteredDate { get; set; }

        public static Student Parse(string name, string email, DateTime registeredDate)
        {
            return new Student
            {
                Name = name,
                Email = email,
                RegisteredDate = registeredDate
            };
        }
    }

    class Town
    {
        public string Name { get; set; }
        public int SeatsCount { get; set; }
        public List<Student> Students { get; set; }

        public static Town Parse(string name, int seats, List<Student> studentsList)
        {
            return new Town
            {
                Name = name,
                SeatsCount = seats,
                Students = new List<Student>()
            };
        }
    }

    class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Town> townList = ReadTownsAndStudents();

            List<Group> groupList = DistributeStudentsIntoGroups(townList);

            PrintGroups(groupList, townList);
        }

        static void PrintGroups(List<Group> groupList, List<Town> townList)
        {
            Console.WriteLine($"Created {groupList.Count} groups in {townList.Count} towns:");

            foreach (Group gr in groupList.OrderBy(t => t.Town.Name))
            {
                Console.WriteLine($"{gr.Town.Name} => {string.Join(", ", gr.Students.Select(x => x.Email))}");
            }
        }

        private static List<Group> DistributeStudentsIntoGroups(List<Town> towns)
        {
            List<Group> groups = new List<Group>();

            foreach (var town in towns.OrderBy(x => x.Name))
            {
                IEnumerable<Student> students = town.Students
                    .OrderBy(d => d.RegisteredDate)
                    .ThenBy(a => a.Name)
                    .ThenBy(e => e.Email);

                while (students.Any())
                {
                    Group group = new Group();
                    group.Town = town;
                    group.Students = students.Take(group.Town.SeatsCount).ToList();
                    students = students.Skip(group.Town.SeatsCount);
                    groups.Add(group);
                }
            }

            return groups;
        }

        private static List<Town> ReadTownsAndStudents()
        {
            List<Town> towns = new List<Town>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                if (input.Contains("=>"))
                {
                    List<string> tokens = Regex.Split(input, @"\s=>\s").ToList();

                    int seats = int.Parse(Regex.Match(tokens[1], @"\d+").Value);

                    string townName = tokens[0];

                    towns.Add(Town.Parse(townName, seats, new List<Student>()));
                }
                else
                {

                    List<string> tokens = input.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();

                    string studentName = tokens[0];
                    string email = tokens[1];
                    DateTime date = DateTime.ParseExact(tokens[2], "d-MMM-yyyy", CultureInfo.InvariantCulture);

                    towns.LastOrDefault().Students.Add(Student.Parse(studentName, email, date));
                }

                input = Console.ReadLine();
            }
            return towns;
        }
    }
}
