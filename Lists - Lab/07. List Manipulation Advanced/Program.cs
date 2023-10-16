namespace _07._List_Manipulation_Advanced
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
            bool isChanged = false;

            while (input != "end")
            {
                string[] cmdArgs = input.Split();

                string command = cmdArgs[0];

                if (command == "Add")
                {
                    isChanged = true;
                    int number = int.Parse(cmdArgs[1]);
                    numbers.Add(number);
                }
                else if (command == "Remove")
                {
                    isChanged = true;
                    int number = int.Parse(cmdArgs[1]);
                    numbers.Remove(number);
                }
                else if (command == "RemoveAt")
                {
                    isChanged = true;
                    int index = int.Parse(cmdArgs[1]);
                    numbers.RemoveAt(index);
                }
                else if (command == "Insert")
                {
                    isChanged = true;
                    int number = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);
                    numbers.Insert(index, number);
                }
                else if (command == "Contains")
                {
                    int number = int.Parse(cmdArgs[1]);

                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command == "PrintEven")
                {
                    Console.WriteLine(
                        string.Join(" ", numbers.Where(x => x % 2 == 0)));
                }
                else if (command == "PrintOdd")
                {
                    Console.WriteLine(
                        string.Join(" ", numbers.Where(x => x % 2 != 0)));
                }
                else if (command == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (command == "Filter")
                {
                    string condition = cmdArgs[1];
                    int number = int.Parse(cmdArgs[2]);

                    if (condition == "<")
                    {
                        Console.WriteLine(
                            string.Join(" ", numbers.Where(x => x < number)));
                    }
                    else if (condition == "<=")
                    {
                        Console.WriteLine(
                            string.Join(" ", numbers.Where(x => x <= number)));
                    }
                    else if (condition == ">")
                    {
                        Console.WriteLine(
                            string.Join(" ", numbers.Where(x => x > number)));
                    }
                    else if (condition == ">=")
                    {
                        Console.WriteLine(
                            string.Join(" ", numbers.Where(x => x >= number)));
                    }
                }

                input = Console.ReadLine();
            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
