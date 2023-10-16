using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            while (number % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                number = int.Parse(Console.ReadLine());
            }

            if (number % 2 == 0)
            {
                Console.WriteLine($"The number is: {Math.Abs(number)}");
            }
        }
    }
}
