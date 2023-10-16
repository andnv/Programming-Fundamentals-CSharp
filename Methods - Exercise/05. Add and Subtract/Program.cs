namespace _05._Add_and_Subtract
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            IntegersSum(firstNum, secondNum);
            SubstractThirdInteger(firstNum, secondNum, thirdNum);
        }
        static int IntegersSum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        static int SubstractThirdInteger(int a, int b, int c)
        {
            int result = IntegersSum(a,b) - c;
            Console.WriteLine(result);
            return result;
        }
    }
}
