namespace _10.Lower_or_Upper
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
            string letter = Console.ReadLine();
            if (letter.All(char.IsLower))
            {
                Console.WriteLine("lower-case");
            }
            else if (letter.All(char.IsUpper))
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
