
namespace _06.Triples_of_Latin_Letters
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
            int number = int.Parse(Console.ReadLine()) + 'a';
            string result = string.Empty;

            for (char i = 'a'; i < number; i++)
            {
                for (char j = 'a'; j < number; j++)
                {
                    for (char k = 'a'; k < number; k++)
                    {
                        result = "" + i + j + k;
                        Console.WriteLine(result);
                    }
                }
            }
        }
    }
}
