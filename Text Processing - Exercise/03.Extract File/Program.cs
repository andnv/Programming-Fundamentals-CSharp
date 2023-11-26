namespace _03.Extract_File
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] filePath = Console.ReadLine()
                .Split("\\");

            string path = filePath[filePath.Length - 1];

            string[] substracts = path.Split(".");

            string name = substracts[0];
            string extension = substracts[1];

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
