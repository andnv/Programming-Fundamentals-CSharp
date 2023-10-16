namespace _09._Palindrome_Integers
{
    using System;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                bool result = IsPalindrome(input);
                Console.WriteLine(result.ToString().ToLower());
                input = Console.ReadLine();
            }
        }

        static bool IsPalindrome(string input)
        {
            int number = int.Parse(input);

            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
