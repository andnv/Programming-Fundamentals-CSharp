
namespace _09.Spice_Must_Flow
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
            int startYield = int.Parse(Console.ReadLine());
            int daysCount = 0;
            int spices = 0;
            int totalSpices = 0;
            int workersConsume = 26;

            if (startYield >= 100) // Трябва да се провери дали началният добив е ПО-ГОЛЯМ или РАВЕН на 100, защото в противен случай, работниците НЕ започват работа!!!
            {
                while (startYield >= 100)
                {
                    daysCount++;
                    spices = startYield - workersConsume;
                    totalSpices += spices;
                    startYield -= 10;
                }

                totalSpices -= workersConsume;
                Console.WriteLine(daysCount);
                Console.WriteLine(totalSpices);  
            }
            else
            {
                Console.WriteLine(daysCount);
                Console.WriteLine(totalSpices);
            }
        }
    }
}
