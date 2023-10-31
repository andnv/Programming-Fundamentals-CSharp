namespace _03._Word_Synonyms
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> synonyms
                = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++) 
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!synonyms.ContainsKey(word))
                {
                    List<string> newListForCurrentWord = new List<string>();
                    synonyms.Add(word, newListForCurrentWord);
                }

                synonyms[word].Add(synonym);
            }

            foreach (var word in synonyms)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }

        }
    }
}
