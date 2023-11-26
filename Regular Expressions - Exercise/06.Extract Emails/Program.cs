namespace _06.Extract_Emails
{
    using System;
    using System.Text.RegularExpressions;
    using static System.Net.Mime.MediaTypeNames;

    internal class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            string pattern = @"(^|(?<=\s))(([a-zA-Z0-9]+)([\.\-_]?)([A-Za-z0-9]+)(@)([a-zA-Z]+([\.\-][A-Za-z]+)+))(\b|(?=\s))";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(inputLine);
            
            if(regex.IsMatch(inputLine))
            {
                foreach (Match email in matches)
                {
                    Console.WriteLine(email);
                }
            }
           
        }
    }
}
