using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());   
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double headsetCost = (lostGames / 2) * headsetPrice;
            double mouseCost = (lostGames / 3) * mousePrice;
            double keyboardCost = (lostGames / 6) * keyboardPrice;
            double displayCost = (lostGames / 12) * displayPrice;

            double expenses = headsetCost + mouseCost + keyboardCost + displayCost; 

            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");

        }
    }
}
