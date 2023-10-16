using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0.0;
            double totalPrice = 0.0;

            if (type == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45;
                }
                else if (day == "Saturday")
                {
                    price = 9.80;
                }
                else if (day == "Sunday")
                {
                    price = 10.46;
                }

                totalPrice = price * people;

                if (people >= 30)
                {
                    totalPrice = totalPrice - totalPrice * 0.15;
                }
            }
            else if (type == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                else if (day == "Saturday")
                {
                    price = 15.60;
                }
                else if (day == "Sunday")
                {
                    price = 16;
                }

                totalPrice = price * people;
                if (people >= 100)
                {
                    totalPrice = totalPrice - 10 * price;
                }
            }
            else if (type == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;
                }
                else if (day == "Sunday")
                {
                    price = 22.50;
                }

                totalPrice = price * people;

                if (people >= 10 && people <= 20)
                {
                    totalPrice = totalPrice - totalPrice * 0.05;
                }
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");

        }
    }
}
