﻿namespace _03.Exact_Sum_of_Real_Numbers
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
            decimal sum = 0;

            for (int i = 1; i <= n; i++)
            {
                decimal numbers = decimal.Parse(Console.ReadLine());
                sum+= numbers;
            }
            Console.WriteLine(sum);
        }
    }
}