namespace _12.Refactor_Special_Numbers
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

            for (int ch = 1; ch <= n; ch++)
            {
                int digit = ch;
                while (ch > 0)
                {
                    sum += ch % 10;
                    ch /= 10;
                }

                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", digit, isSpecial);
                sum = 0;
                ch = digit; 
            }
        }
    }
}
