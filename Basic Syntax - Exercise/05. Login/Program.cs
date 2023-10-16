using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            int counter = 1;
            string reversedPassword = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                reversedPassword += username[i];
            }

            while (reversedPassword != password)
            {
                Console.WriteLine("Incorrect password. Try again.");
                password = Console.ReadLine();
                counter++;

                if (counter == 4 && reversedPassword != password)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
            }
            if (reversedPassword==password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
