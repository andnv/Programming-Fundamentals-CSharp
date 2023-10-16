
namespace _04.Sum_of_Chars
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
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                char character = char.Parse(Console.ReadLine());
                int number = (int)character;
                sum += number;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
