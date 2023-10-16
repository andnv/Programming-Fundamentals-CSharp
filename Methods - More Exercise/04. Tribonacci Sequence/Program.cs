namespace _04._Tribonacci_Sequence
{
    using System;
    using System.Numerics;

    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            TribonacciSequence(num);
        }

        static void TribonacciSequence(int num)
        {
            int first = 1;
            int second = 1;
            int third = 2;
            int sum = first + second + third;

            if (num == 1)
            {
                Console.WriteLine(1);
            }
            else if (num == 2)
            {
                Console.WriteLine("1 1");
            }
            else
            {
                Console.Write("1 1 2 ");
            }

            for (int i = 4; i <= num; i++)
            {
                Console.Write($"{sum} ");
                first = second;
                second = third;
                third = sum;
                sum = first + second + third;
            }
            Console.WriteLine();
        }
    }
}
