namespace _01.Reverse_Strings
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
           
            while ((input = Console.ReadLine()) != "end")
            {
                string currWord = input;
                string reversed = string.Empty;

                for (int i = currWord.Length - 1; i >= 0; i--)
                {
                    char ch = currWord[i];
                    reversed += ch;
                }

                Console.WriteLine($"{currWord} = {reversed}");
            }
        }
    }
}
