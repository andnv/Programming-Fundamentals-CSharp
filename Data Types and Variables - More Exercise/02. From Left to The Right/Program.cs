using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.From_Left_to_The_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long leftNumber = 0;
            long rightNumber = 0;

            for (int input = 1; input <= n; input++)
            {
                string numbers = Console.ReadLine();
                string leftNumAsString = string.Empty;
                string rightNumAsString = string.Empty;
                bool isLeftNum = true;
                bool isNegative = false;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (isLeftNum && numbers[i] != ' ')
                    {
                        if (numbers[i] == '-')
                        {
                            isNegative = true;
                            continue;
                        }

                        leftNumAsString += numbers[i];

                        if (isNegative == true)
                        {
                            leftNumber = long.Parse(leftNumAsString) * (-1);
                        }
                        else
                        {
                            leftNumber = long.Parse(leftNumAsString);
                        }
                    }
                    else if (!isLeftNum && numbers[i] != ' ')
                    {
                        if (numbers[i] == '-')
                        {
                            isNegative = true;
                            continue;
                        }

                        rightNumAsString += numbers[i];

                        if (isNegative == true)
                        {
                            rightNumber = long.Parse(rightNumAsString)*(-1);
                        }
                        else 
                        {
                            rightNumber = long.Parse(rightNumAsString);
                        }
                    }
                    else if (numbers[i] == ' ')
                    {
                        isLeftNum = false;
                    }
                }
                int leftSum = 0;
                int rightSum = 0;

                if (leftNumber > rightNumber)
                {
                    for (int l = 0; l < leftNumAsString.Length; l++)
                    {
                        leftSum += int.Parse(leftNumAsString[l].ToString());
                    }
                    Console.WriteLine(leftSum);
                }
                else if (leftNumber < rightNumber)
                {
                    for (int r = 0; r < rightNumAsString.Length; r++)
                    {
                        rightSum += int.Parse(rightNumAsString[r].ToString());
                    }
                    Console.WriteLine(rightSum);
                }
                else if (leftNumber == rightNumber)
                {
                    for (int r = 0; r < rightNumAsString.Length; r++)
                    {
                        rightSum += int.Parse(rightNumAsString[r].ToString());
                    }
                    Console.WriteLine(rightSum);
                }

                leftNumber = 0;
                rightNumber=0;
            }
        }
    }
}
