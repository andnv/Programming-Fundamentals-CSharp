﻿namespace _04._Word_Filter
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .Where(w => w.Length % 2 == 0)
                  .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, words));
           
        }
    }
}
