using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());    
            int number3 = int.Parse(Console.ReadLine());

            int sum = number1 + number2 + number3; 

            int largest = Math.Max(Math.Max(number1, number2),number3);
            int smallest = Math.Min(Math.Min(number1, number2), number3);
            int middle = sum - (largest + smallest);

            Console.WriteLine(largest);
            Console.WriteLine(middle);
            Console.WriteLine(smallest);

        }
    }
}
