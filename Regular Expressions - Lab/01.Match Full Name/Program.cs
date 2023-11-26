namespace _01.Match_Full_Name
{
    using System;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string text = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            foreach (Match currentMatch in matches) 
            {
                Console.Write(currentMatch.Value + " ");
            }
        }
    }
}
