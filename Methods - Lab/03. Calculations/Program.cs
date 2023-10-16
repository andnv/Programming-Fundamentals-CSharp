
namespace _03._Calculations
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    AddCommand(firstNum, secondNum);
                    break;
                case "multiply":
                    MultiplyCommand(firstNum, secondNum);
                    break;
                case "subtract":
                    SubtractCommand(firstNum, secondNum);
                    break;
                case "divide":
                    DivideCommand(firstNum, secondNum);
                    break;
            }
        }
        static void AddCommand(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum + secondNum);
        }
        static void MultiplyCommand(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum * secondNum);
        }
        static void SubtractCommand(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum - secondNum);
        }
        static void DivideCommand(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum / secondNum);
        }
    }
}
