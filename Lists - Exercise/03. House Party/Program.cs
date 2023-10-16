namespace _03._House_Party
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] cmdArgs = input.Split(' ');
                string name = cmdArgs[0];
                string goingOrNot = cmdArgs[2];

                if (goingOrNot == "going!")
                {
                    if (names.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        names.Add(name);
                    }
                }
                else if (goingOrNot == "not")
                {
                    if (names.Contains(name))
                    {
                        names.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }

            }

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
