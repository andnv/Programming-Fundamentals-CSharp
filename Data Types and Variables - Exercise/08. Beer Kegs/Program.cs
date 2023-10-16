
namespace _08.Beer_Kegs
{
    using Microsoft.Win32;
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
            string model = string.Empty;
            double volume = 0;
            double biggestVolume = 0;
            string biggestKeg = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                volume = Math.PI * Math.Pow(radius, 2) * height;
                if (biggestVolume < volume)
                {
                    biggestVolume = volume;
                    biggestKeg = model;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
