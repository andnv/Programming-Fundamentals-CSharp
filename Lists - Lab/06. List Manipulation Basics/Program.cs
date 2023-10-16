namespace _06._List_Manipulation_Basics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                      .Split()
                      .Select(int.Parse)
                      .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] cmdArgs = input.Split();

                string command = cmdArgs[0];
                
                if (command == "Add")
                {
                    int number = int.Parse(cmdArgs[1]);
                    numbers.Add(number);
                }
                else if (command == "Remove")
                {
                    int number = int.Parse(cmdArgs[1]);
                    numbers.Remove(number);
                }
                else if (command == "RemoveAt")
                {
                    int index = int.Parse(cmdArgs[1]);
                    numbers.RemoveAt(index);
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);
                    numbers.Insert(index, number);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
