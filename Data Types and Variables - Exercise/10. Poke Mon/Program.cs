
namespace _10.Poke_Mon
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
            int power = int.Parse(Console.ReadLine()); //N
            int distance = int.Parse(Console.ReadLine()); //M
            int exhaustionFactor = int.Parse(Console.ReadLine()); // Y

            int pokedTargets = 0;
            double percentage = (double)power * 0.50;

            if (power >= distance)
            {
                while (power >= distance)
                {
                    power -= distance;
                    pokedTargets++;

                    if (power == percentage && exhaustionFactor != 0)
                    {
                        power /= exhaustionFactor;
                        continue;
                    }
                }
                Console.WriteLine(power);
                Console.WriteLine(pokedTargets);
            }
            else
            {
                Console.WriteLine(power);
                Console.WriteLine(pokedTargets);
            }
        }
    }
}
