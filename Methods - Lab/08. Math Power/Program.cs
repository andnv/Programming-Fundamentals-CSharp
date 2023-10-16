
namespace _08._Math_Power
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            double result = MathPower(firstNum,secondNum);
            Console.WriteLine(result);
        }

        static double MathPower(double firstNum, double secondNum)
        {
            return Math.Pow(firstNum, secondNum);
        }
    }
}
