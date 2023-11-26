namespace _08.Letters_Change_Numbers
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            foreach (string currentString in input)
            {
                char firstLetter = currentString[0];
                char lastLetter = currentString[^1]; // the last char

                string numAsString = currentString[1..^1]; //everything between index 1 and the last index
                double numFromString = double.Parse(numAsString);

                if (char.IsUpper(firstLetter))
                {
                    int position = firstLetter - 64; // all upper letters  
                    numFromString /= position;
                }
                else
                {
                    int position = firstLetter - 96; // all lower letters
                    numFromString *= position;
                }

                if (char.IsUpper(lastLetter))
                {
                    int position = lastLetter - 64;
                    numFromString -= position;
                }
                else
                {
                    int position = lastLetter - 96;
                    numFromString += position;
                }
                sum += numFromString;
            }
            Console.WriteLine($"{sum:F2}");
        }
    }
}
