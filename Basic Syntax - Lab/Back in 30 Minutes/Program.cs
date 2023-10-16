using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_in_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int finalMinutes = minutes + 30;
            if (finalMinutes > 59)
            {
                hours++;
                finalMinutes -= 60;
            }
            if (hours > 23)
            {
                hours = 0;
            }

            if (finalMinutes < 10)
            {
                Console.WriteLine($"{hours}:0{finalMinutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{finalMinutes}");
            }
        }
    }
}
