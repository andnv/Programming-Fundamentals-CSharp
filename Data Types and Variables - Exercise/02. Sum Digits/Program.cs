
namespace _02.Sum_Digits
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
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = number.ToString().Length-1; i >= 0; i--)
            {
                int lastDigit = number % 10;
                number /= 10;
                sum+= lastDigit;
            }
            Console.WriteLine(sum);
        }
    }
}
