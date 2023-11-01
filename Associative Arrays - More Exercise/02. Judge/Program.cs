namespace _02._Judge
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Design;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> contests 
                = new Dictionary<string, Dictionary<string, int>>();

            Dictionary<string, int> users 
                = new Dictionary<string, int>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] contestInfo = input
                    .Split(" -> ",StringSplitOptions.RemoveEmptyEntries);

                string username = contestInfo[0];
                string contestName = contestInfo[1];
                int points = int.Parse(contestInfo[2]);

                if (!contests.ContainsKey(contestName))
                {
                    contests.Add(contestName, new Dictionary<string, int>());
                    contests[contestName][username] = points;
                }
                else
                {
                    if (!contests[contestName].ContainsKey(username))
                    {
                        contests[contestName][username] = points;
                    }
                    else
                    {
                        if (contests[contestName][username] < points)
                        {
                            contests[contestName][username] = points;
                        }
                    }
                }
            }

            foreach (var contest in contests)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
                int counter = 1;

                foreach (var name in contest.Value
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{counter}. {name.Key} <::> {name.Value}");
                    counter++;
                }
            }

            foreach (var contest in contests)
            {
                foreach (var name in contest.Value)
                {
                    if (!users.ContainsKey(name.Key))
                    {
                        users.Add(name.Key, name.Value);
                    }
                    else
                    {
                        users[name.Key] = users[name.Key] + name.Value;
                    }
                }
            }

            int countUsers = 1;

            Console.WriteLine($"Individual standings:");

            foreach (var name in users.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{countUsers}. {name.Key} -> {name.Value}");
                countUsers++;
            }
        }
    }
}