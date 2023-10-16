namespace _04.Centuries_to_Minutes

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
            int centuriesNum = int.Parse(Console.ReadLine());
            int years = centuriesNum * 100;
            int days = (int)(years * 365.2422);
            int hours = 24 * days;
            int minutes = 60 * hours;

            Console.WriteLine($"{centuriesNum} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
