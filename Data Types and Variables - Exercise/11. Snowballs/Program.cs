
namespace _11.Snowballs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Numerics;
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberSnowballs = int.Parse(Console.ReadLine());

            BigInteger maxValue = 0;
            string bestResult = string.Empty;

            for (int i = 1; i <= numberSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow(snowballSnow/snowballTime,snowballQuality);

                if (snowballValue > maxValue)
                {
                    maxValue = snowballValue;
                    string result = $"{snowballSnow} : {snowballTime} = {maxValue} ({snowballQuality})"; //За стойност на въведените променливи се взема текущата, при която условието е приело най-високата стойност.
                    bestResult = result;
                }
            }
            Console.WriteLine(bestResult);
        }
    }
}
