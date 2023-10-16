
namespace _05.Decrypting_Message
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
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i = 1; i <= lines; i++)
            {
                char character = char.Parse(Console.ReadLine());
                int characterWithKey = (int)character + key;
                char newCharacter = (char)characterWithKey;
                message += newCharacter;
            }
            Console.WriteLine(message);
        }
    }
}
