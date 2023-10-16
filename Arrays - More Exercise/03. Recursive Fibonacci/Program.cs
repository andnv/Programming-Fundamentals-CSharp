
namespace _03._Recursive_Fibonacci
{
    using System;
    internal class Program
    {
        static long[] numbers;
        static long FibonacciRecursion(int n)
        {
            if (numbers[n] != 0)
            {
                return numbers[n];
            }
            if (n <= 2)
            {
                return 1;
            }

            long result = FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
            numbers[n] = result;
            return result;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            numbers = new long[100];
            Console.WriteLine(FibonacciRecursion(n));
        }
    }
}
