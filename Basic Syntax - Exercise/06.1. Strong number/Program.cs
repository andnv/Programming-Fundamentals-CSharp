using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._1.Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int number = input;
            int sum = 0;
            int remain;

            while (number != 0)
            {
                remain = number % 10;
                number = number / 10;

                int fact = 1; //Декларира се точно ПРЕДИ цикъла, иначе не започва всеки път от 1!!!
                for (int i = 1; i <= remain; i++)
                {
                    fact *= i;
                }
                sum += fact;
            }

            if (sum == input)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
