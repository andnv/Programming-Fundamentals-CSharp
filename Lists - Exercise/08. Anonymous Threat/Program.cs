namespace _08._Anonymous_Threat
{
    using Microsoft.VisualBasic;
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lineOfStrings = Console.ReadLine()
                         .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                         .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];

                if (command == "merge")
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);

                    if (startIndex < 0) 
                    {
                        startIndex = 0;
                    }

                    if (endIndex >= lineOfStrings.Count)
                    {
                        endIndex = lineOfStrings.Count - 1;
                    }

                    MerageStrings(lineOfStrings, startIndex, endIndex);

                }
                else if (command == "divide")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int partitions = int.Parse(cmdArgs[2]);

                    DivideStrings(lineOfStrings, index, partitions);
                }
            }

            Console.WriteLine(string.Join(" ", lineOfStrings));
        }

        static void DivideStrings(List<string> lineOfStrings, int index, int partitions)
        {
            string currentString = lineOfStrings[index];
            int lengthOfSubstrings = currentString.Length;

            lineOfStrings[index] = string.Empty;

            if (lengthOfSubstrings % partitions == 0)
            {
                lengthOfSubstrings /= partitions;

                for (int currentSymbol = 0; currentSymbol < currentString.Length; currentSymbol++)
                {
                    if (currentSymbol != 0 && currentSymbol % lengthOfSubstrings == 0)
                    {
                        index++;
                        lineOfStrings.Insert(index, string.Empty);
                    }

                    lineOfStrings[index] += currentString[currentSymbol];
                }
            }
            else
            {
                lengthOfSubstrings = lengthOfSubstrings / partitions <= 0 ? 1 : lengthOfSubstrings / partitions;
                int countOfSubstrings = partitions;

                for (int currentSymbol = 0; currentSymbol < currentString.Length; currentSymbol++)
                {
                    if (currentSymbol != 0 && currentSymbol % lengthOfSubstrings == 0 && countOfSubstrings > 1)
                    {
                        index++;
                        lineOfStrings.Insert(index, string.Empty);
                        countOfSubstrings--;
                    }

                    lineOfStrings[index] += currentString[currentSymbol];
                }
            }
        }

        static void MerageStrings(List<string> lineOfStrings, int startIndex, int endIndex)
        {
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                lineOfStrings[startIndex] += lineOfStrings[startIndex + 1];
                lineOfStrings.RemoveAt(startIndex + 1);
            }
        }
    }
}
