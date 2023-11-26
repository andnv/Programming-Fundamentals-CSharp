namespace _01.Valid_Usernames
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            bool isValid = false;

            foreach (string word in words) 
            {
                if (word.Length >= 3 && word.Length <= 16)
                {
                    foreach (char ch in word) 
                    {
                        if (char.IsLetterOrDigit(ch) ||
                            ch == '-' ||
                            ch == '_')
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        Console.WriteLine(word);
                    }
                }
            }
        }
    }
}
