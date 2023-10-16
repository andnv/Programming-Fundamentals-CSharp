
namespace _06.Balanced_Brackets
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
            int lines = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 1; i <= lines; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    counter++;
                }
                if (input == ")")
                {
                    counter--;
                }
                if (counter < 0)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
            }
            if (counter==0)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
