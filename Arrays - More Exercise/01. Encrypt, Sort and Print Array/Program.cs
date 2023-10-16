
namespace _01._Encrypt__Sort_and_Print_Array
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] sequenceOfStrings = new string [n];
            int[] valueOfString = new int[n];


            for (int i = 0; i < sequenceOfStrings.Length; i++)
            {
                int vowelsSum = 0;
                int consonantSum = 0;

                sequenceOfStrings[i] = Console.ReadLine();

                foreach (char index in sequenceOfStrings[i])
                {
                    if (index == 'a' || index == 'e' || index == 'i' || index == 'o' || index == 'u'
                        || index == 'A' || index == 'E' || index == 'I' || index == 'O' || index == 'U')
                    {
                        vowelsSum += ((int)index * sequenceOfStrings[i].Length);
                    }
                    else
                    {
                        consonantSum += ((int)index / sequenceOfStrings[i].Length);
                    }
      
                }

                int stringSum = vowelsSum + consonantSum;
                valueOfString[i] = stringSum;
            }

            Array.Sort(valueOfString);
            foreach (int value in valueOfString)
            {
                Console.WriteLine(value);
            }
        }
    }
}
