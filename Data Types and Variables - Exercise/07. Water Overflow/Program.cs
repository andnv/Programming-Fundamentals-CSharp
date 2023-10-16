
namespace _07.Water_Overflow
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
            int capacity = 255;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int quantities = int.Parse(Console.ReadLine());
                if (sum + quantities > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sum+= quantities;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
