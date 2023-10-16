namespace _10._Top_Number
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintTopNumbersUpTo(input);
        }
        static bool IsSumOfDigitsDivisibleByEight(int number)
        {
            int digitSum = 0;

            while (number > 0)
            {
                digitSum += number % 10;
                number /= 10;
            }

            if (digitSum % 8 == 0)
            {
                return true;
            }

            return false;
        }

        static bool HoldsAtLeastOneOddDigit(int number)
        {
            while (number > 0)
            {
                if ((number % 10) % 2 != 0)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }
        static void PrintTopNumbersUpTo(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                bool isSumDivisible = IsSumOfDigitsDivisibleByEight(i);
                bool holdsOddDigits = HoldsAtLeastOneOddDigit(i);

                if (isSumDivisible == true && holdsOddDigits == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
