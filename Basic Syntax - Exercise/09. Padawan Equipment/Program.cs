using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountMoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            int freeBelts = students / 6; //Всеки 6-ти колан е безплатен.

            double totalLightsabersPrice = lightsabersPrice*Math.Ceiling(students+students*0.1);
            double totalRobesPrice = students * robesPrice;
            double totalBeltsPrice = beltsPrice*(students-freeBelts);

            double totalMoney = totalLightsabersPrice + totalRobesPrice + totalBeltsPrice;


            if (amountMoney >= totalMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoney:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalMoney - amountMoney:F2}lv more.");
            }

        }
    }
}
