
namespace _02._Pascal_Triangle
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n >= 1 && n <= 60)
            {
                for (int row = 0; row < n; row++)
                {
                    int number = 1;

                    for (int col = 0; col <= row; col++)
                    {
                        Console.Write(number + " ");
                        number = number * (row - col) / (col + 1);
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
