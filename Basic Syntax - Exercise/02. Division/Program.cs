using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _02.Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int number = 0;

            if (input % 2 == 0)
            {
                number = 2;
            }
            if (input % 3 == 0)
            {
                number = 3;
            }
            if (input % 6 == 0)
            {
                number = 6;
            }
            if (input % 7 == 0)
            {
                number = 7;
            }
            if (input % 10 == 0)
            {
                number = 10;
            }

            if (input % 2 == 0 || input % 3 == 0 || input % 6 == 0 || input % 7 == 0 || input % 10 == 0)
            {
                Console.WriteLine($"The number is divisible by {number}");
            }
            else if (input % 2 != 0 && input % 3 != 0 && input % 6 != 0 && input % 7 != 0 && input % 10 != 0)
            {
                Console.WriteLine("Not divisible");
            }

        }
    }
}
