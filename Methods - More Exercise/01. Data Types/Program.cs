namespace _01._Data_Types
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "int")
            {
                int num = int.Parse(Console.ReadLine());
                MultiplyNumber(input, num);
            }
            else if (input == "real")
            {
                double num = double.Parse(Console.ReadLine());
                MultiplyNumber(input, num);
            }
            else if (input == "string")
            {
                string word = Console.ReadLine();
                Console.WriteLine($"${word}$");
            }
        }

        static void MultiplyNumber(string input, double num)
        {
            if (input == "int")
            {
                int result = (int)num * 2;
                Console.WriteLine(result);
            }
            else if (input == "real")
            {
                double result = num * 1.5;
                Console.WriteLine($"{result:F2}");
            }
        }
    }
}
