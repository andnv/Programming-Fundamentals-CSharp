namespace _05._Bomb_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                      .Select(int.Parse)
                      .ToList();

            int[] numbers = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();

            int specialNum = numbers[0];
            int powerNum = numbers[1];

            for (int i = 0; i < sequence.Count; i++)
            {
                int currentNum = sequence[i];

                if (currentNum == specialNum)
                {
                    int startIndex = i - powerNum;
                    int endIndex = i + powerNum;

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex >= sequence.Count)
                    {
                        endIndex = sequence.Count - 1;
                    }

                    int endIndexToRemove = endIndex - startIndex + 1; 
                    sequence.RemoveRange(startIndex, endIndexToRemove);
                    i = startIndex - 1;
                }
            }
            Console.WriteLine(sequence.Sum());
        }
    }
}
