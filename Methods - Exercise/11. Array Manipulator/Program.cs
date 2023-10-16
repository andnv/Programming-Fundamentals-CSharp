namespace _11._Array_Manipulator
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Xml.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = string.Empty;
            
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split(" ");
                string cmdType = cmdArgs[0];

                if (cmdType == "exchange")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (index < 0 || index >= array.Length)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    array = ExchangeArray(array,index);
                  
                }
                else if (cmdType == "max" || cmdType == "min")
                {
                    string evenOrOddArg = cmdArgs[1];
                    int indexOfElement;
                    
                    if (cmdType == "max")
                    {
                        indexOfElement = IndexOfMaxEvenOrOddElement(array, evenOrOddArg);
                    }
                    else 
                    {
                        indexOfElement = IndexOfMinEvenOrOddElement(array, evenOrOddArg);
                    }
                    if (indexOfElement == -1)
                    {
                        //Ако не сме намерили такъв елемент
                        Console.WriteLine("No matches");
                        continue;
                    }

                    Console.WriteLine(indexOfElement);
                }
                else if (cmdType == "first" || cmdType == "last")
                {
                    int count = int.Parse(cmdArgs[1]);
                    string evenOrOddArg = cmdArgs[2];
                    
                    if (count > array.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    int[] elements;
                    if (cmdType == "first")
                    {
                        elements = FirstEvenOrOddElement(array, count, evenOrOddArg);
                    }
                    else
                    {
                        elements = LastEvenOrOddElement(array, count, evenOrOddArg);
                    }
                    PrintArray(elements);
                }
            }
            PrintArray(array);
        }
        
        static int[] ExchangeArray(int[] array, int index)
        {
            int[] modifiedArray = new int[array.Length];
            int modifiedArrIndex = 0;

            for (int i = index + 1; i < array.Length; i++)
            {
                modifiedArray[modifiedArrIndex++] = array[i]; //Първо ще сложи елементът на индекс 0, а след това ще се увеличи с 1.
            }

            for (int i = 0; i <= index; i++)
            {
                modifiedArray[modifiedArrIndex++] = array[i]; 
            }

            return modifiedArray;
        }

        static int IndexOfMaxEvenOrOddElement(int[] array, string evenOrOddArg)
        {
            //Default-на стойност, която показва, че НЯМА съвпадения. 
            int maxIndex = -1;
            int currentMax = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                int currentNum = array[i];
                if (evenOrOddArg == "even" && currentNum % 2 == 0)
                {
                    if (currentNum >= currentMax)  //>=, защото се иска НАЙ-ДЯСНАТА стойност (ако се иска най-ЛЯВАТА -> само >)
                    {
                        currentMax = currentNum;
                        maxIndex = i;
                    }
                }
                else if (evenOrOddArg == "odd" && currentNum % 2 != 0)
                {
                    if (currentNum >= currentMax)  
                    {
                        currentMax = currentNum;
                        maxIndex = i;
                    }
                } 
            }

            return maxIndex;
        }

        static int IndexOfMinEvenOrOddElement(int[] array, string evenOrOddArg)
        {
            //Default-на стойност, която показва, че НЯМА съвпадения.
            int minIndex = -1;
            int currentMin = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                int currentNum = array[i];
                if (evenOrOddArg == "even" && currentNum % 2 == 0)
                {
                    if (currentNum <= currentMin)  //>=, защото се иска НАЙ-ДЯСНАТА стойност (ако се иска най-ЛЯВАТА -> само >)
                    {
                        currentMin = currentNum;
                        minIndex = i;
                    }
                }
                else if (evenOrOddArg == "odd" && currentNum % 2 != 0)
                {
                    if (currentNum <= currentMin)
                    {
                        currentMin = currentNum;
                        minIndex = i;
                    }
                }
            }

            return minIndex;
        }

        static int[] FirstEvenOrOddElement(int[] array, int count, string evenOrOddArg)
        {
            int[] firstElementArr = new int[count];
            int firstElementArrIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (firstElementArrIndex >= count)
                {
                    break;
                }

                int currNum = array[i];

                if (evenOrOddArg == "even" && currNum % 2 == 0)
                {
                    firstElementArr[firstElementArrIndex++] = currNum;
                }
                else if (evenOrOddArg == "odd" && currNum % 2 != 0)
                {
                    firstElementArr[firstElementArrIndex++] = currNum;
                }
            }

            firstElementArr = ResizeArray(firstElementArr, firstElementArrIndex);
            return firstElementArr;
        }

        static int[] LastEvenOrOddElement(int[] array, int count, string evenOrOddArg)
        {
            int[] lastElementArr = new int[count];
            int lastElementArrIndex = 0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (lastElementArrIndex >= count)
                {
                    break;
                }

                int currNum = array[i];

                if (evenOrOddArg == "even" && currNum % 2 == 0)
                {
                    lastElementArr[lastElementArrIndex++] = currNum;
                }
                else if (evenOrOddArg == "odd" && currNum % 2 != 0)
                {
                    lastElementArr[lastElementArrIndex++] = currNum;
                }
            }

            lastElementArr = ResizeArray(lastElementArr, lastElementArrIndex);
            lastElementArr = ReverseArray(lastElementArr);
            return lastElementArr; 
        }

        static int[] ResizeArray(int[] array, int count)
        {
            int[] modifiedArray = new int[count];

            for (int i = 0; i < count; i++)
            {
                modifiedArray[i] = array[i];
            }

            return modifiedArray;
        }

        static int[] ReverseArray(int[] array)
        {
            int[] reversedArr = new int[array.Length];  

            for (int i = array.Length - 1; i >= 0; i--)
            {
                reversedArr[reversedArr.Length-i-1] = array[i];
            }

            return reversedArr;
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine($"[{String.Join(", ", array)}]");
        }
    }
}
