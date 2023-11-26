namespace _02.Race
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Dictionary<string,int> participantsInfo
                = new Dictionary<string,int>();

            Regex name = new Regex(@"[A-Za-z]");
            Regex distance = new Regex(@"[0-9]");

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end of race")
            {
                string currentPerson = string.Empty;
                int kilometers = 0;

                foreach (Match match in name.Matches(input))
                {
                    currentPerson += match.Value;
                }
                foreach (Match match in distance.Matches(input))
                {
                    kilometers += int.Parse(match.Value);
                }

                if (participants.Contains(currentPerson))
                {
                    if (participantsInfo.ContainsKey(currentPerson))
                    {
                        participantsInfo[currentPerson] += kilometers;
                    }
                    else
                    {
                        participantsInfo.Add(currentPerson, kilometers);
                    }
                }
            }

            int place = 1;

            foreach (var racer in participantsInfo.OrderByDescending(km => km.Value))
            {
                if (place == 1)
                {
                    Console.WriteLine($"1st place: {racer.Key}");
                    place++;
                }
                else if (place == 2)
                {
                    Console.WriteLine($"2nd place: {racer.Key}");
                    place++;
                }
                else if (place == 3)
                {
                    Console.WriteLine($"3rd place: {racer.Key}");
                    break;
                }
            }
        }
    }
}
