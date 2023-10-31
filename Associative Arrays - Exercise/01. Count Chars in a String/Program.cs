namespace _01._Count_Chars_in_a_String
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<char, int> counts 
                = new Dictionary<char, int>();

            string[] words = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();

            foreach (var word in words)
            {

                foreach (char ch in word)
                {
                    if (!counts.ContainsKey(ch))
                    {
                        if (char.IsWhiteSpace(ch))
                        {
                            break;
                        }
                        counts.Add(ch, 0);
                    }

                    counts[ch] += 1;
                }
            }

            foreach (var ch in counts)
            {
                Console.WriteLine($"{ch.Key} -> {ch.Value}");
            }
        }
    }
}
