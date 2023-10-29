namespace _02._Oldest_Family_Member
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < peopleCount; i++)
            {
                string[] familyMembersInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string memberName = familyMembersInfo[0];
                int memberAge = int.Parse(familyMembersInfo[1]);

                Person person = new Person(memberName, memberAge);
                family.AddMember(person);
            }

            Person oldestMember = family.GetOldestPerson(family.FamilyMembers);

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }

    public class Family
    {
        private readonly List<Person> familyMembers = new List<Person>();

        public List<Person> FamilyMembers
            => this.familyMembers;


        public void AddMember(Person member) 
        {
            FamilyMembers.Add(member);
        }

        public Person GetOldestPerson(List<Person> familyMembers)
        {
            Person oldestMember = familyMembers.OrderByDescending(m => m.Age).First();
            return oldestMember;
        }
    }

    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}
