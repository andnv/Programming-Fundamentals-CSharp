namespace _03._MOBA_Challenger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> players 
                = new Dictionary<string, Dictionary<string, int>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Season end")
            {
                string[] commandArgs = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string splitter = commandArgs[1];

                if (splitter == "->")
                {
                    string player = commandArgs[0];
                    string position = commandArgs[2];
                    int skill = int.Parse(commandArgs[4]);

                    if (!players.ContainsKey(player))
                    {
                        players.Add(player, new Dictionary<string, int>());
                        players[player].Add(position, skill);
                    }
                    else
                    {
                        if (!players[player].ContainsKey(position))
                        {
                            players[player].Add(position, skill);
                        }
                        else
                        {
                            if (players[player][position] < skill)
                            {
                                players[player][position] = skill;
                            }
                        }
                    }
                }
                else if (splitter == "vs")
                {
                    string firstPlayer = commandArgs[0];
                    string secondPlayer = commandArgs[2];

                    if (players.ContainsKey(firstPlayer) && players.ContainsKey(secondPlayer))
                    {
                        bool commonPosition = false;

                        foreach (var position in players[firstPlayer].Keys)
                        {
                            if (players[secondPlayer].ContainsKey(position))
                            {
                                commonPosition = true;
                            }
                        }

                        if (commonPosition == true)
                        {
                            int playerOneTotalSkill = players[firstPlayer].Sum(x => x.Value);
                            int playerTwoTotalSkill = players[secondPlayer].Sum(x => x.Value);

                            if (playerOneTotalSkill > playerTwoTotalSkill)
                            {
                                players.Remove(secondPlayer);
                            }
                            else if (playerOneTotalSkill < playerTwoTotalSkill)
                            {
                                players.Remove(firstPlayer);
                            }
                        }
                    }
                }
            }

            foreach (var player in players
                    .OrderByDescending(x => x.Value.Values.Sum())
                    .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");

                foreach (var position in player.Value
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }
    }
}
