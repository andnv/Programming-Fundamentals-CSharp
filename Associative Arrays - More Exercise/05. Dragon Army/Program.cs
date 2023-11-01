namespace _05._Dragon_Army
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<int>>> dragonArmy 
                = new Dictionary<string, Dictionary<string, List<int>>>();

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();

                string[] inputArgs = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string type = inputArgs[0];
                string name = inputArgs[1];
                var damage = inputArgs[2] == "null" ? 45 : int.Parse(inputArgs[2]);
                var health = inputArgs[3] == "null" ? 250 : int.Parse(inputArgs[3]);
                var armor = inputArgs[4] == "null" ? 10 : int.Parse(inputArgs[4]);

                if (!dragonArmy.ContainsKey(type))
                {
                    dragonArmy.Add(type, new Dictionary<string, List<int>>());
                }

                dragonArmy[type][name] = new List<int>();

                dragonArmy[type][name].Add(damage);
                dragonArmy[type][name].Add(health);
                dragonArmy[type][name].Add(armor);
            }

            foreach (var type in dragonArmy)
            {
                double avgDamage = (double)(type.Value.Values.Select(x => x[0]).Sum()) / dragonArmy[type.Key].Count;
                double avgHealth = (double)(type.Value.Values.Select(x => x[1]).Sum()) / dragonArmy[type.Key].Count;
                double avgArmor = (double)(type.Value.Values.Select(x => x[2]).Sum()) / dragonArmy[type.Key].Count;

                Console.WriteLine($"{type.Key}::({avgDamage:F2}/{avgHealth:F2}/{avgArmor:F2})");


                foreach (var dragon in type.Value
                    .OrderBy(x => x.Key))
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }
    }
}
