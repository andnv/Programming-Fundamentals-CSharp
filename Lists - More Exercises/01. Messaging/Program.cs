namespace _01._Messaging
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lineOfNumbers = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToList();

            List<char> str = new List<char>();
            str.AddRange(Console.ReadLine());

            for (int i = 0; i < lineOfNumbers.Count; i++)
            {
                int index = 0;
                int currentNum = lineOfNumbers[i];

                while (currentNum > 0)
                {
                    int lastDigit = currentNum % 10;
                    index += lastDigit;
                    currentNum /= 10;
                }

                int times = index / str.Count;
                index = index - times * str.Count;
                Console.Write(str[index]);
                str.RemoveAt(index);

            }

        }
    }
}
