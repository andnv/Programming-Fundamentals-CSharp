namespace _05._Students_2._0
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

                bool exists = false;
                
                foreach (Student currentStudent in students)
                {
                    if (currentStudent.FirstName == student.FirstName
                        && currentStudent.LastName == student.LastName)
                    {
                        currentStudent.Age = student.Age;
                        currentStudent.HomeTown = student.HomeTown;
                        exists = true;
                    }
                }
                
                if (!exists)
                {
                    students.Add(student);
                }
               
            }

            string city = Console.ReadLine();

            foreach (Student currentStudent in students)
            {
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
