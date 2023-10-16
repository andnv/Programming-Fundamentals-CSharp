
namespace _10._Multiply_Evens_by_Odds
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = Math.Abs(int.Parse(Console.ReadLine()));

            int result = GetMultipleOfEvenAndOdds(input);
            Console.WriteLine(result);
        }

        static int GetSumOfEvenDigits(int number)
        {
            int evenSum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;

                if (lastDigit % 2 == 0)
                {
                    evenSum += lastDigit;
                }

                number /= 10;
            }

            return evenSum;
        }
        static int GetSumOfOddDigits(int number)
        {
            int oddSum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;

                if (lastDigit % 2 != 0)
                {
                    oddSum += lastDigit;
                }

                number /= 10;
            }

            return oddSum;
        }
        static int GetMultipleOfEvenAndOdds(int sum)
        {
            int result = GetSumOfEvenDigits(sum) * GetSumOfOddDigits(sum);
            return result;
        }
    }
}
