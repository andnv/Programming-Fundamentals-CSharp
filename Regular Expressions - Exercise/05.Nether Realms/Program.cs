namespace _05.Nether_Realms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<double, double>> demons 
                = new Dictionary<string, Dictionary<double, double>>();
            

            Regex patternHealth = new Regex(@"([^\d\+\-\*\/\.\,])");
            Regex patternDamage = new Regex(@"-?\d+\.?\d*");
            Regex patternMultiply = new Regex(@"[\*]");
            Regex patternDivide = new Regex(@"[\/]");

            string[] input = Console.ReadLine()
                .Split(new[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(x => x)
                .ToArray();

            foreach (var demon in input)
            {
                string demonName = string.Empty;
                double currentHealth = 0;
                double currentDamage = 0;
                int divideCount = 0;
                int multiplyCount = 0;

                foreach (Match match in patternMultiply.Matches(demon))
                {
                    multiplyCount++;
                }

                foreach (Match match in patternDivide.Matches(demon))
                {
                    divideCount++;
                }

                foreach (Match match in patternHealth.Matches(demon))
                {
                    demonName += match.Value;
                }

                foreach (var letter in demonName)
                {
                    currentHealth += letter;
                }


                foreach (Match match in patternDamage.Matches(demon))
                {
                    currentDamage += double.Parse(match.Value);
                }

                for (int i = 0; i < multiplyCount; i++)
                {
                    currentDamage *= 2;
                }
                for (int i = 0; i < divideCount; i++)
                {
                    currentDamage /= 2;
                }

                Dictionary<double, double> demonInfo 
                    = new Dictionary<double, double>();

                demonInfo.Add(currentHealth, currentDamage);

                demons.Add(demon, demonInfo);
            }

            foreach (var demon in demons.OrderBy(n => n.Key))
            {
                foreach (var currentDemon in demon.Value)
                {
                    Console.WriteLine($"{demon.Key} - {currentDemon.Key} health, {currentDemon.Value:F2} damage");
                }
            }
        }
    }
}
