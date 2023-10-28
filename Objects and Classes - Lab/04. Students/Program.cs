namespace _04._Students
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            List<Student> students = new List<Student>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] studentInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                int age = int.Parse(studentInfo[2]);
                string homeTown = studentInfo[3];

                Student student = new Student(firstName, lastName, age, homeTown);  
                students.Add(student);

            }

            string city = Console.ReadLine();

            for (int i = 0; i < students.Count; i++)
            {
                Student currentStudent = students[i];

                if (city == currentStudent.HomeTown)
                {
                    Console.WriteLine($"{currentStudent.FirstName} {currentStudent.LastName} is {currentStudent.Age} years old.");
                }
            }
        }
    }

    public class Student
    {
        private readonly List<string> students;

        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string HomeTown { get; set; }

        public List<string> Students
            => this.Students;
    }
}
