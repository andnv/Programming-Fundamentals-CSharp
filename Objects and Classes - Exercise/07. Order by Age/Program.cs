namespace _07._Order_by_Age
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            List<Person> persons = new List<Person>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] personInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string nameOfPerson = personInfo[0];
                string personID = personInfo[1];
                int age = int.Parse(personInfo[2]);

                Person person = new Person (nameOfPerson, personID, age);

                bool exists = false;

                foreach (Person currentPerson in persons) 
                {
                    if (currentPerson.ID == person.ID)
                    {
                        currentPerson.Name = person.Name;
                        currentPerson.Age = person.Age;
                        exists = true;
                    }
                }

                if (!exists)
                {
                    persons.Add(person);
                }
            }

            foreach (Person currentPerson in persons.OrderBy(p => p.Age))
            {
                Console.WriteLine($"{currentPerson.Name} with ID: {currentPerson.ID} is {currentPerson.Age} years old.");
            }
        }
    }

    public class Person
    {
        public Person(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }

        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }
    }
}
