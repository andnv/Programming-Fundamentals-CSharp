namespace _03._Characters_in_Range
{
    using System;
    using System.ComponentModel;

    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            RangeOfCharacters(firstChar, secondChar);
        }

        static void RangeOfCharacters(char a, char b)
        {
            int firstChar = (int)a;
            int secondChar = (int)b;

            if (secondChar < firstChar)
            {
                (firstChar, secondChar) = (secondChar, firstChar);
            }

            for (int i = firstChar + 1; i < secondChar; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
        }
    }
}
