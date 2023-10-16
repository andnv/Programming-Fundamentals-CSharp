
namespace _08.Magic_Sum
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
            int[] arr = Console.ReadLine()
                      .Split()
                      .Select(int.Parse)
                      .ToArray();

            int num = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == num)
                    {
                        Console.WriteLine($"{arr[i]} {arr[j]} ");
                    }
                }
            }
        }
    }
}
