﻿namespace _04.Text_Filter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (string word in bannedWords)
            {
                text = text.Replace(word, 
                    new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}
