namespace _04._Mixed_up_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstLine = Console.ReadLine()
                      .Split()
                      .Select(int.Parse)
                      .ToList();

            List<int> secondLine = Console.ReadLine()
                      .Split()
                      .Select(int.Parse)
                      .ToList();

            int minList = Math.Min(firstLine.Count,secondLine.Count);
            int maxList = Math.Max(firstLine.Count, secondLine.Count);

            List<int> combined = new List<int>(minList);
            List<int> result= new List<int>(maxList-minList);

            secondLine.Reverse();

            for (int i = 0; i < minList; i++)
            {
                combined.Add(firstLine[i]);
                combined.Add(secondLine[i]);
            }

            int constraintOne = 0;
            int constraintTwo = 0;   

            if (firstLine.Count > secondLine.Count)
            {
                constraintOne = firstLine[firstLine.Count - 1];
                constraintTwo = firstLine[firstLine.Count - 2];
            }
            else
            {
                constraintOne = secondLine[secondLine.Count - 1];
                constraintTwo = secondLine[secondLine.Count - 2];
            }

            int smallerConstraint = Math.Min(constraintOne, constraintTwo);
            int biggerConstraint = Math.Max(constraintOne, constraintTwo);

            result = combined.Where(n => n > smallerConstraint && n < biggerConstraint)
                             .ToList();

            result.Sort();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
