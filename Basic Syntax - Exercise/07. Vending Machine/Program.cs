using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = string.Empty;
            double validCoins = 0;
            double price = 0;
            double sum = 0;
            
            string input = Console.ReadLine();

            while (input != "Start")
            {
                validCoins = double.Parse(input);

               if (validCoins == 0.1 || validCoins == 0.2 || validCoins == 0.5 || validCoins == 1 || validCoins == 2)
               {
                    sum += validCoins;
               }
               else
               {
                    Console.WriteLine($"Cannot accept {validCoins}");
               }

                input = Console.ReadLine();
            }

            product = Console.ReadLine();

            while (product != "End")
            {
                product = product.ToLower();
                bool invalidProduct = false; 
                switch (product)
                {
                     case "nuts":
                         price = 2.0;
                         break;
                     case "water":
                         price = 0.7;
                         break;
                     case "crisps":
                         price = 1.5;
                         break;
                     case "soda":
                         price = 0.8;
                         break;
                     case "coke":
                         price = 1.0;
                         break;
                     default:
                         Console.WriteLine("Invalid product");
                         invalidProduct = true; 
                         break;
                }
                if (invalidProduct == false) 
                {
                    if (sum >= price)
                    {
                        Console.WriteLine($"Purchased {product}");
                        sum -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }

             product = Console.ReadLine();
            }
                
            Console.WriteLine($"Change: {sum:F2}");
        }
    }
}
