
namespace _06.Equal_Sum
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

            int leftSum = 0;
            int rightSum = 0;
            bool exists = false;

            for (int i = 0; i < arr.Length; i++)
            {

                for (int l = 0; l < i; l++)
                {
                    leftSum += arr[l];
                }
                for (int r = i + 1; r < arr.Length; r++)
                {
                    rightSum += arr[r];
                }

                if (leftSum == rightSum)
                {
                    exists = true;
                    Console.WriteLine(i);
                    break;
                }
                leftSum = 0;
                rightSum = 0;
            }

            if (exists==false) 
            {
                Console.WriteLine("no");
            }

        }
    }
}
