namespace _02.Character_Multiplier
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int totalSum = SumOfCharacters(words[0], words[1]);
            Console.WriteLine(totalSum);

        }

        public static int SumOfCharacters(string firstString, string secondString)
        {
            int sum = 0;
            int minLengthString = Math.Min(firstString.Length, secondString.Length);

            for (int i = 0; i < minLengthString; i++)
            {
                sum += firstString[i] * secondString[i];
            }

            string longestString = firstString;

            if (longestString.Length < secondString.Length)
            {
                longestString = secondString;
            }

            for (int i = minLengthString; i < longestString.Length; i++)
            {
                sum += longestString[i];
            }

            return sum;
           
        }
    }
}
