
namespace _09.Kamino_Factory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading.Tasks;
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] currentSequence = new int[length];
            int[] bestSequence = new int[length];
            string input = string.Empty;

            int bestLength = 1;
            int bestStartIndex = 0;
            int bestSequenceSum = 0;
            int bestSequenceIndex = 0;

            int sequenceCounter = 0;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                currentSequence = input
                    .Split("!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                sequenceCounter++;

                int lengthCount = 1;
                int bestCurrentLength = 1;
                int startIndex = 0;
                int currSeqSum = 0;

                for (int i = 0; i < currentSequence.Length - 1; i++)
                {
                    if (currentSequence[i] == currentSequence[i + 1])
                    {
                        lengthCount++;
                    }
                    else
                    {
                        lengthCount = 1;
                    }

                    if (lengthCount > bestCurrentLength)
                    {
                        bestCurrentLength = lengthCount;
                        startIndex = i;
                    }

                    currSeqSum += currentSequence[i];

                }
                currSeqSum += currentSequence[currentSequence.Length - 1];

                if (bestCurrentLength > bestLength)
                {
                    bestLength = bestCurrentLength;
                    bestStartIndex = startIndex;
                    bestSequenceSum = currSeqSum;
                    bestSequenceIndex = sequenceCounter;
                    bestSequence = currentSequence.ToArray();
                }
                else if (bestCurrentLength == bestLength)
                {
                    if (startIndex < bestStartIndex)
                    {
                        bestLength = bestCurrentLength;
                        bestStartIndex = startIndex;
                        bestSequenceSum = currSeqSum;
                        bestSequenceIndex = sequenceCounter;
                        bestSequence = currentSequence.ToArray();
                    }
                    else if (startIndex == bestStartIndex)
                    {
                        if (currSeqSum > bestSequenceSum)
                        {
                            bestLength = bestCurrentLength;
                            bestStartIndex = startIndex;
                            bestSequenceSum = currSeqSum;
                            bestSequenceIndex = sequenceCounter;
                            bestSequence = currentSequence.ToArray();
                        }
                    }
                }
            }
                Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
                Console.WriteLine(string.Join(" ", bestSequence));
        }
    }
}
