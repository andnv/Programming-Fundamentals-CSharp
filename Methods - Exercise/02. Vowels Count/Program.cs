
namespace _02._Vowels_Count
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int result = VowelsCount(input);
            Console.WriteLine(result);
        }

        static int VowelsCount(string input)
        {
            int vowelsCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (currentChar == 'a' || currentChar == 'e' || currentChar == 'i' 
                    || currentChar == 'o' || currentChar == 'u' || currentChar == 'A' 
                    || currentChar == 'E' || currentChar == 'I' || currentChar == 'O' 
                    || currentChar == 'U')
                {
                    vowelsCount++;
                }
            }

            return vowelsCount;
        }
    }
}
