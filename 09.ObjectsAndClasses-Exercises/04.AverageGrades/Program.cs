using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.AverageGrades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double GradesAverage
        {
            get { return Grades.Average(); }
        }

        public static Student Parse(string name, List<double> grades)
        {
            Student student = new Student
            {
                Name = name,
                Grades = grades
            };
            return student;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsList = ReadStudents();

            foreach (Student student in studentsList.Where(x => x.GradesAverage >= 5).ToList().OrderBy(name => name.Name).ThenByDescending(av => av.GradesAverage))
            {
                Console.WriteLine($"{student.Name} -> {student.GradesAverage:f2}");
            }
        }

        private static List<Student> ReadStudents()
        {
            List<Student> studList = new List<Student>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<double> grades = new List<double>();
                string[] tokens = Console.ReadLine().Split(' ');
                string name = tokens[0];

                for (int j = 1; j < tokens.Length; j++)
                {
                    grades.Add(double.Parse(tokens[j]));
                }
                Student student = Student.Parse(name, grades);
                studList.Add(student);
            }
            return studList;
        }
    }
}
