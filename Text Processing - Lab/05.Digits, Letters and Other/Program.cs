namespace _05.Digits__Letters_and_Other
{
    using System;
    using System.Runtime.Serialization;

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string digits = string.Empty;
            string letters = string.Empty;  
            string chars = string.Empty;

            foreach (char ch in input)
            {
                if (char.IsDigit(ch))
                {
                    digits += ch;
                }
                else if(char.IsLetter(ch))
                {
                    letters += ch;
                }
                else
                {
                    chars += ch;
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(chars);
        }
    }
}
