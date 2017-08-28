using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _08.MentorGroup
{
    class Student
    {
        public List<String> Comments { get; set; }
        public List<DateTime> Dates { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> userData = new Dictionary<string, Student>();

            string firstInput = Console.ReadLine();

            while (firstInput != "end of dates")
            {
                string[] tokens = firstInput.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];

                List<DateTime> dateList = new List<DateTime>();

                for (int i = 1; i < tokens.Length; i++)
                {
                    DateTime date = DateTime.ParseExact(tokens[i], $"dd/MM/yyyy", CultureInfo.InvariantCulture);
                    dateList.Add(date);
                }

                if (!userData.ContainsKey(name))
                {
                    userData.Add(name, new Student());
                    userData[name].Dates = new List<DateTime>();
                    userData[name].Dates.AddRange(dateList);
                }
                else
                {
                    userData[name].Dates.AddRange(dateList);
                }
                userData[name].Comments = new List<string>();

                firstInput = Console.ReadLine();
            }

            string secondInput = Console.ReadLine();

            while (secondInput != "end of comments")
            {
                string[] tokens = secondInput.Split('-');
                string name = tokens[0];
                string comment = tokens[1];

                if (userData.ContainsKey(name))
                {
                    userData[name].Comments.Add(comment);
                }

                secondInput = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Student> nameStudentPair in userData.OrderBy(a => a.Key))
            {
                Console.WriteLine($"{nameStudentPair.Key}");

                Console.WriteLine($"Comments:");
                foreach (string comment in nameStudentPair.Value.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine($"Dates attended:");
                foreach (DateTime date in nameStudentPair.Value.Dates.OrderBy(d => d))
                {
                    Console.WriteLine($"-- {date.ToString($"dd/MM/yyyy")}");
                }
            }
        }
    }
}
