﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pounds_To_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pounds = double.Parse(Console.ReadLine());
            double dollars = pounds * 1.31;
            Console.WriteLine($"{dollars:F3}");
        }
    }
}
