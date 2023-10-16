using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.English_Name_of_the_Last_Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int lastDigit = ReturnedValue(number);
            string spelling = string.Empty;

            if (lastDigit == 0)
            {
                spelling = "zero";
            }
            else if (lastDigit == 1)
            {
                spelling = "one";
            }
            else if (lastDigit == 2)
            {
                spelling = "two";
            }
            else if (lastDigit == 3)
            {
                spelling = "three";
            }
            else if (lastDigit == 4)
            {
                spelling = "four";
            }
            else if (lastDigit == 5)
            {
                spelling = "five";
            }
            else if (lastDigit == 6)
            {
                spelling = "six";
            }
            else if (lastDigit == 7)
            {
                spelling = "seven";
            }
            else if (lastDigit == 8)
            {
                spelling = "eight";
            }
            else if (lastDigit == 9)
            {
                spelling = "nine";
            }
            Console.WriteLine(spelling);
        }

        public static int ReturnedValue(int number)
        {
            number %= 10;
            return number;
        }
    }
}
