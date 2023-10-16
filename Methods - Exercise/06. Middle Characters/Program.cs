namespace _06._Middle_Characters
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(MiddleCharacter(input));
        }

        static string MiddleCharacter(string input)
        {
            string result = string.Empty;

            if (input.Length % 2 == 0)
            {
                result = input[input.Length / 2 - 1].ToString() + input[input.Length / 2].ToString();
            }
            else
            {
                result = input[input.Length / 2].ToString();

            }
            return result;
        }
    }
}
