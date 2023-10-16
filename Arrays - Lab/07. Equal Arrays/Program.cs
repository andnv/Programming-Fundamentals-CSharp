
namespace _07.Equal_Arrays
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
            int[] firstArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] secondArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            bool isIdentical = false;

            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    isIdentical = false;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                else
                {
                    isIdentical = true;
                    sum += firstArr[i];
                }
            }
            
            if (isIdentical == true) 
            { 
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }

        }
    }
}
