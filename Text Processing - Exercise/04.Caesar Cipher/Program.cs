namespace _04.Caesar_Cipher
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();   
            string encrypted = string.Empty;

            foreach (char ch in text)
            {
                int newPosition = ch + 3;
                encrypted += (char)newPosition;
            }

            Console.WriteLine(encrypted);
        }
    }
}
