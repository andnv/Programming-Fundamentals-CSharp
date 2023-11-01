namespace _01._Ranking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests 
                = new Dictionary<string, string>();

            Dictionary<string, Dictionary<string, int>> results
                = new Dictionary<string, Dictionary<string, int>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] contestArgs = input
                    .Split(":");

                string contest = contestArgs[0];
                string password = contestArgs[1];

                if (!contests.ContainsKey(contest))
                {
                    contests[contest] = password;
                }
            }

            string secondInput = string.Empty;

            while ((secondInput = Console.ReadLine()) != "end of submissions")
            {
                string[] submissionsArgs = secondInput
                    .Split("=>");

                string contestName = submissionsArgs[0];
                string contestPassword = submissionsArgs[1];
                string username = submissionsArgs[2];
                int points = int.Parse(submissionsArgs[3]);

                if (contests.ContainsKey(contestName) && contests[contestName] == contestPassword)
                {
                    if (!results.ContainsKey(username))
                    {
                        results[username] = new Dictionary<string, int>();
                    }

                    if (results.ContainsKey(username) && !results[username].ContainsKey(contestName))
                    {
                        results[username][contestName] = 0;
                    }

                    if (results[username][contestName] < points)
                    {
                        results[username][contestName] = points;
                    }
                }
            }

            string winner = results
                .OrderBy(x => x.Value.Values
                .Sum())
                .Last().Key;

            int bestTotalPoints = results
                .OrderBy(x => x.Value.Values
                .Sum())
                .Last()
                .Value.Values.Sum();

            Console.WriteLine($"Best candidate is {winner} with total {bestTotalPoints} points.");
            Console.WriteLine("Ranking:");

            foreach (var item in results
                .OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);

                foreach (var contest in item.Value
                    .OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }

}
