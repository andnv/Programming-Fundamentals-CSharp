
namespace _05.Top_Integers
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
            int[] input = Console.ReadLine()
                      .Split()
                      .Select(int.Parse)
                      .ToArray();


            for (int i = 0; i < input.Length; i++)
            {
                int currentNum = input[i];
                bool isTopInt = true;

                for (int j = i + 1; j < input.Length; j++)
                {
                    int nextNum = input[j];
                    if (nextNum >= currentNum)
                    {
                        isTopInt = false;
                        break;
                    }
                }
                if (isTopInt)
                {
                    Console.Write(currentNum + " ");
                }
            }
        }
    }
}
