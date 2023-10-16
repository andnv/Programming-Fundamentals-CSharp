namespace _05.Special_Numbers

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

            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int lastDigit = i;
                bool isSpecial = false;

                for (int j = 0; j < i.ToString().Length; j++)
                {
                    sum += lastDigit % 10;
                    lastDigit /= 10;

                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecial = true;
                }
                Console.WriteLine($"{i} -> {isSpecial}");
            }

        }
    }
}
