namespace _09.Chars_to_String
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
            string sum = string.Empty;

            for (int i = 1; i <= 3; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                sum += ch;
            }
            Console.WriteLine(sum);
        }
    }
}
