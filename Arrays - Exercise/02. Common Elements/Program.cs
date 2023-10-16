
namespace _02.Common_Elements
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
            string[] arr1 = Console.ReadLine()
                .Split()
                .ToArray();

            string[] arr2 = Console.ReadLine()
                .Split()
                .ToArray();

            foreach (string str in arr2) 
            {
                if (arr1.Contains(str))
                {
                    Console.Write(str + " ");
                }
            }
            
        }
    }
}
