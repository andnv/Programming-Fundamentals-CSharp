namespace _02._Car_Race
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();

            int finalIndex = numbers.Length / 2;
            float leftRacerTime = 0;
            float rightRacerTime = 0;


            for (int i = 0; i < finalIndex; i++)
            {
                leftRacerTime += numbers[i];

                if (numbers[i] == 0)
                {
                    leftRacerTime *= 0.8f;
                }

            }

            for (int i = numbers.Length - 1; i > finalIndex; i--)
            {
                rightRacerTime += numbers[i];

                if (numbers[i] == 0)
                {
                    rightRacerTime *= 0.8f;
                }

            }

            if (leftRacerTime < rightRacerTime)
            {
                Console.WriteLine($"The winner is left with total time: {leftRacerTime}");
            }
            else if (rightRacerTime < leftRacerTime)
            {
                Console.WriteLine($"The winner is right with total time: {rightRacerTime}");
            }
        }
    }
}
