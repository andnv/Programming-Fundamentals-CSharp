namespace _09._Pokemon_Don_t_Go
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        { 
            List<int> sequence = Console.ReadLine()
                      .Split()
                      .Select(int.Parse)
                      .ToList();

            int sum = 0;

            while (sequence.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    int firstNum = sequence[0];
                    sum += firstNum;
                    sequence[0] = sequence[sequence.Count - 1];

                    RemoveNum(sequence, firstNum);
                }
                else if (index >= sequence.Count)
                {
                    int lastNum = sequence[sequence.Count - 1]; 
                    sum += lastNum;
                    sequence[sequence.Count - 1] = sequence[0];

                    RemoveNum(sequence, lastNum);
                }
                else 
                {
                    int removedNum = sequence[index];
                    sum += removedNum;
                    sequence.RemoveAt(index);
                    RemoveNum(sequence, removedNum);

                }
            }

            Console.WriteLine(sum);
        }

        static void RemoveNum(List<int> sequence, int removedNum)
        {

            for (int i = 0; i < sequence.Count; i++)
            {

                if (sequence[i] <= removedNum)
                {
                    sequence[i] += removedNum;
                }
                else
                {
                    sequence[i] -= removedNum;
                }

            }
        }
    }
}
