using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            
            if (multiplier <= 10)
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    Console.WriteLine($"{input} X {i} = {input * i}");
                }
            }

            else
            {
                Console.WriteLine($"{input} X {multiplier} = {input * multiplier}");
            }
        }
    }
}
