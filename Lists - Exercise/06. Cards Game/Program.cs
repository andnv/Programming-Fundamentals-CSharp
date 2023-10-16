namespace _06._Cards_Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine()
                      .Split()
                      .Select(int.Parse)
                      .ToList();

            List<int> secondPlayer = Console.ReadLine()
                      .Split()
                      .Select(int.Parse)
                      .ToList();

            while (firstPlayer.Count > 0 && secondPlayer.Count > 0)
            {

                if (firstPlayer[0] > secondPlayer[0])
                {
                    firstPlayer.Add(secondPlayer[0]);
                    firstPlayer.Add(firstPlayer[0]);
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }
                else if (secondPlayer[0] > firstPlayer[0])
                {
                    secondPlayer.Add(firstPlayer[0]);
                    secondPlayer.Add(secondPlayer[0]);
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }
                else
                {
                    firstPlayer.Remove(firstPlayer[0]);
                    secondPlayer.Remove(secondPlayer[0]);
                }
            }

            int sumOfFirstPlayer = firstPlayer.Sum();
            int sumOfSecondPlayer = secondPlayer.Sum();

            string winner = string.Empty;
            int result = 0;

            if (sumOfFirstPlayer > sumOfSecondPlayer)
            {
                winner = "First";
                result = sumOfFirstPlayer;
            }
            else if (sumOfSecondPlayer > sumOfFirstPlayer)
            {
                winner = "Second";
                result = sumOfSecondPlayer;
            }

            Console.WriteLine($"{winner} player wins! Sum: {result}");
        }
    }
}
