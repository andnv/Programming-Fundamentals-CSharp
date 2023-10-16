namespace _04._List_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] cmdArgs = input.Split(' ');
                string command = cmdArgs[0];

                if (command == "Add")
                {
                    int value = int.Parse(cmdArgs[1]);
                    numbers.Add(value);
                }
                else if (command == "Insert")
                {
                    int value = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);

                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, value);
                    }
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(cmdArgs[1]);

                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else if (command == "Shift")
                {
                    string direction = cmdArgs[1];
                    int count = int.Parse(cmdArgs[2]);

                    if (direction == "right")
                    {
                        
                        for (int i = 0; i < count; i++)
                        {
                            int lastNum = numbers[numbers.Count - 1];
                            numbers.RemoveAt(numbers.Count - 1);
                            numbers.Insert(0, lastNum);
                        }
                        
                    }
                    else if (direction == "left")
                    {
                        
                        for (int i = 0; i < count; i++)
                        {
                            int firstNum = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(firstNum);
                        }
       
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
