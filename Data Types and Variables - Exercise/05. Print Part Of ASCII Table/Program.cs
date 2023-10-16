
namespace _05.Print_Part_Of_ASCII_Table
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
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());
            string result = string.Empty;
            
            for (char i = (char)startIndex; i <= (char)endIndex; i++)
            {
                result += i + " ";
            }
            Console.WriteLine(result);
        }
    }
}
