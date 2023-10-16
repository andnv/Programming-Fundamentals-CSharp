namespace _07.Concat_Names
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
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();   
            string delimiter = Console.ReadLine();  

            Console.WriteLine(firstName + delimiter + lastName);
        }
    }
}
