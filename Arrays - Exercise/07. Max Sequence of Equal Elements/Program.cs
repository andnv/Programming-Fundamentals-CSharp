
namespace _07.Max_Sequence_of_Equal_Elements
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

            int equalsCount = 1;
            int maxEquals = 1;
            int startIndex = 0;

            for (int i = 1; i < arr.Length; i++)
            { 
                
                if (arr[i] == arr[i-1])
                {
                    equalsCount++;
                    if (equalsCount > maxEquals)
                    {
                        startIndex = arr[i];
                        maxEquals = equalsCount;
                    }
                }
                else
                {
                    equalsCount = 1;
                }
            }
            for (int j = 0; j < maxEquals; j++)
            {
                Console.Write(startIndex + " ");
            }
            Console.WriteLine();
        }
    }
}
