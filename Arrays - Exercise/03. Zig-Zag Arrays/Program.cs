
namespace _03.Zig_Zag_Arrays
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
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse) 
                    .ToArray();

                int firstNum = input[0];
                int secondNum = input[1];   

                if (i % 2 == 0)
                {
                    arr1[i] = firstNum;
                    arr2[i] = secondNum;
                }
                else
                {
                    arr1[i] = secondNum;
                    arr2[i] = firstNum;
                }
            }
            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));
        }
    }
}
