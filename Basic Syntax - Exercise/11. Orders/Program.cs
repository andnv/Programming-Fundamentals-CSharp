using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            double pricePerCapsule;
            int days;
            int capsulesCount;
            double orderPrice;
            double totalPrice = 0;

            for (int i = 1; i <= orders; i++)
            {
                pricePerCapsule = double.Parse(Console.ReadLine());
                days = int.Parse(Console.ReadLine());
                capsulesCount = int.Parse(Console.ReadLine());

                orderPrice = (days * capsulesCount) * pricePerCapsule;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");
                totalPrice += orderPrice;

            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
