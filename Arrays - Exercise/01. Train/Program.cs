
namespace _01.Train
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < numbers.Length; j++)
            {
                sum += numbers[j];
                Console.Write(numbers[j] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
