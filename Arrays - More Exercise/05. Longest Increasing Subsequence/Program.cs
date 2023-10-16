
namespace _05._Longest_Increasing_Subsequence
{
    using System;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] sequence = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int[] lis;
            int[] len = new int[sequence.Length];
            int[] prev = new int[sequence.Length];
            int maxLength = 0;
            int lastIndex = -1;

            for (int i = 0; i < sequence.Length; i++)
            {
                len[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (sequence[j] < sequence[i] && len[j] >= len[i])
                    {
                        len[i] = len[j] + 1;
                        prev[i] = j;
                    }
                }

                if (len[i] > maxLength)
                {
                    maxLength = len[i];
                    lastIndex = i;
                }
            }

            lis = new int[maxLength];
            for (int k = 0; k < maxLength; k++)
            {
                lis[k] = sequence[lastIndex];
                lastIndex = prev[lastIndex];
            }
            Array.Reverse(lis);
            Console.WriteLine(string.Join(" ", lis));
        }
    }
}
