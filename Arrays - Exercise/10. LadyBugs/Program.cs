
namespace _10.LadyBugs
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
            int n = int.Parse(Console.ReadLine());
            int[] field = new int[n];

            int[] initialIndexes = Console.ReadLine()
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            foreach (int index in initialIndexes) 
            {
                if (index >= 0 && index < field.Length)
                {
                    field[index] = 1;
                }
            }

            string command = string.Empty;
            while ((command = Console.ReadLine())!= "end")
            {
                string[] cmdArgs = command
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                int ladybugIndex = int.Parse(cmdArgs[0]);
                string direction = cmdArgs[1];
                int flyLength = int.Parse(cmdArgs[2]);

                if (ladybugIndex < 0 || ladybugIndex >= field.Length)
                {
                    continue;
                }

                if (field[ladybugIndex] == 0)
                {
                    continue;
                }

                field[ladybugIndex] = 0;

                if (direction == "left")
                {
                    flyLength *= -1;
                }

                int nextIndex = ladybugIndex + flyLength;
                while (nextIndex >= 0 && nextIndex < field.Length && field[nextIndex] == 1) 
                {
                    nextIndex += flyLength;
                }

                if (nextIndex < 0 || nextIndex >= field.Length)
                {
                    continue;
                }

                field[nextIndex] = 1;

            }

            Console.WriteLine(string.Join(" ", field));

        }
    }
}
