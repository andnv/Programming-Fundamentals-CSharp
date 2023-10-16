namespace _01._Train
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> passengersInEachWagon = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];

                if (command == "Add")
                {
                    int addPassengers = int.Parse(cmdArgs[1]);
                    passengersInEachWagon.Add(addPassengers);
                }
                else
                {
                    int incomingPassengers = int.Parse(cmdArgs[0]);

                    for (int i = 0; i < passengersInEachWagon.Count; i++)
                    {
                        if (passengersInEachWagon[i] < maxCapacity &&
                            passengersInEachWagon[i] + incomingPassengers <= maxCapacity)
                        {
                            passengersInEachWagon[i] += incomingPassengers;
                            i = -1;
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", passengersInEachWagon));
        }
    }
}
