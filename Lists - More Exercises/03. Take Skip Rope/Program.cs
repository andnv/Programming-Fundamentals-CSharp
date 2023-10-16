namespace _03._Take_Skip_Rope
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            string encrypted = Console.ReadLine();

            List<string> numbersList = new List<string>();
            List<string> nonNumbersList = new List<string>();

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            List<string> decrypted = new List<string>();


            foreach (var ch in encrypted)
            {
                if (char.IsDigit(ch))
                {
                    numbersList.Add(ch.ToString());
                }
                else
                {
                    nonNumbersList.Add(ch.ToString());
                }
            }
            
            for (int i = 0; i < numbersList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(int.Parse(numbersList[i]));
                }
                else
                {
                    skipList.Add(int.Parse(numbersList[i]));
                }
            }

            int take = 0;
            int skip = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                take = takeList[i];
                int start = skip;
                int end = start + take;

                if (end > nonNumbersList.Count)
                {
                    end = nonNumbersList.Count;
                }

                for (int j = start; j < end; j++)
                {
                    decrypted.Add(nonNumbersList[j]);
                }

                skip += skipList[i] + take;

            }

            Console.WriteLine(string.Join("", decrypted));
        }
    }
}
