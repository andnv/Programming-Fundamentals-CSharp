namespace _05._Courses
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses
                = new Dictionary<string, List<string>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] commandArgs = input
                    .Split(" : ",StringSplitOptions.RemoveEmptyEntries);

                string courseName = commandArgs[0];
                string studentName = commandArgs[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new List<string>() {studentName};
                }
                else
                {
                    courses[courseName].Add(studentName);
                }
            }

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                
                foreach (var students in course.Value)
                {
                    Console.WriteLine($"-- {students}");
                }
            }
        }
    }
}
