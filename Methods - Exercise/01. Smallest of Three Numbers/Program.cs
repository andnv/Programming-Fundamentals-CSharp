
namespace _01._Smallest_of_Three_Numbers
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int result = SmallestNumber(firstNum,secondNum,thirdNum);
            Console.WriteLine(result);
        }

        static int SmallestNumber(int a, int b, int c)
        {
            int smallestNum = 0;

            if (a <= b && a <= c)
            {
                smallestNum = a;
            }
            else if (b <= a && b <= c)
            {
                smallestNum = b;
            }
            else
            {
                smallestNum = c;
            }

            return smallestNum;
        }
    }
}
