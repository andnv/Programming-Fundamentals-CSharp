namespace _06.Replace_Repeating_Chars
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string fixedText = string.Empty;

            char previousChar = '0';

            foreach (char ch in text)
            {
                if (ch != previousChar)
                {
                    fixedText += ch;
                }

                previousChar = ch;
            }

            Console.WriteLine(fixedText);
        }
    }
}
