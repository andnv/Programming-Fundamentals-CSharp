namespace _07._Repeat_String
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            RepeatString(input, num);

        }

        static void RepeatString(string input, int num)
        {
            string result = string.Empty;

            for (int i = 1; i <= num; i++)
            {
                result += input;
            }
            Console.WriteLine(result);
        }
    }
}
