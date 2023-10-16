using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();

            double totalSpent = 0;
            double price = 0;
            bool validGame = false;

            while (game != "Game Time")
            {
                switch (game)
                {
                    case "OutFall 4":
                        price = 39.99;
                        validGame = true;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        validGame = true;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        validGame = true;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        validGame = true;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        validGame = true;
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        validGame = true;
                        break;
                }


                if (validGame == true && currentBalance >= price)
                {
                    totalSpent += price;
                    currentBalance -= price;

                    if (currentBalance >= 0)
                    {
                        Console.WriteLine($"Bought {game}");
                    }
                    else if (currentBalance < 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                }
                else if (validGame == true && currentBalance < price)
                {
                    Console.WriteLine("Too Expensive");
                }
                else if (validGame == false)
                {
                    Console.WriteLine("Not Found");
                }
                game = Console.ReadLine();
            }

            if (game == "Game Time")
            {
                if (currentBalance <= 0)
                {
                    Console.WriteLine("Out of money!");
                }
                else
                {
                    Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${currentBalance:F2}");
                }
            }
        }
    }
}
