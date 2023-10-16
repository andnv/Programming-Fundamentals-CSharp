
namespace _11._Math_operations
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());

            double result = Calculate(firstNum,operation,secondNum);
            Console.WriteLine(result);
        }

        static double Calculate(int a, string operation, int b)
        {
            double result = 0;

            switch (operation)
            {
                case "/":
                    result = a / b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
            }

            return result;
        }
    }
}
