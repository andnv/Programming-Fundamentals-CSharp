namespace _03.Substring
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string specialWord = Console.ReadLine();
            string word = Console.ReadLine();

            while (word.Contains(specialWord))
            {
                int startIndex = word.IndexOf(specialWord);
                word = word.Remove(startIndex, specialWord.Length);
            }

            Console.WriteLine(word);
        }
    }
}
