namespace _05._Drum_Set
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal savings = decimal.Parse(Console.ReadLine());

            List<int> set = Console.ReadLine()
                      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                      .Select(int.Parse)
                      .ToList();

            List<int> price = new List<int>();
            price.AddRange(set);

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int power = int.Parse(input);

                for (int i = 0; i < set.Count; i++)
                {
                    set[i] -= power;

                    if (set[i] <= 0)
                    {
                        if (savings - (price[i] * 3) >= 0)
                        {
                            savings = savings - (price[i] * 3);
                            set[i] = price[i];
                        }
                    }
                }

                for (int i = 0; i < set.Count; i++)
                {
                    if (set[i] <= 0)
                    {
                        set.Remove(set[i]);
                        price.Remove(price[i]);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", set));
            Console.WriteLine($"Gabsy has {savings:F2}lv.");
        }
    }
}
