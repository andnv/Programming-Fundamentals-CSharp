using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int letters = int.Parse(Console.ReadLine());
            string word = string.Empty;

            for (int i = 1; i <= letters; i++)
            {
                string currDigit = Console.ReadLine(); 
                int mainDigit = int.Parse(currDigit[0].ToString());

                if (mainDigit == 8 || mainDigit == 9)
                {
                    int offset = ((mainDigit - 2) * 3) + 1;
                    int offsetInSquare = currDigit.Length;
                    int totalOffset = offset + offsetInSquare - 1;
                    char letter = (char)(97 + totalOffset);
                    word += letter;
                }
                else if (mainDigit == 0)
                {
                    word += ' ';
                }
                else
                {
                    int offset = (mainDigit - 2) * 3;
                    int offsetInSquare = currDigit.Length;
                    int totalOffset = offset + offsetInSquare - 1;
                    char letter = (char)(97 + totalOffset);
                    word += letter;
                }
            }
            Console.WriteLine(word);
        }
    }
}
