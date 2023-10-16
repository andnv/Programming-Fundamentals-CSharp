using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreign_Languages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string countryName = Console.ReadLine();
            string language = " ";

            switch (countryName)
            {
                case "England":
                case "USA":
                    language = "English";
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    language = "Spanish";
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }

            Console.WriteLine(language);
        }
    }
}
