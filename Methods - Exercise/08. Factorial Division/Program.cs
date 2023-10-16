namespace _08._Factorial_Division
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            long firstNum = long.Parse(Console.ReadLine());
            long secondNum = long.Parse(Console.ReadLine());

            double firstSum = FactorialOfNum(firstNum);
            double secondSum = FactorialOfNum(secondNum);

            double result = firstSum / secondSum;
            Console.WriteLine($"{result:F2}");

        }

        static double FactorialOfNum(long num)
        {
            long sum = 1;

            for (long i = 1; i <= num; i++)
            {
                sum *= i;
            }

            return sum;
        }
    }
}
