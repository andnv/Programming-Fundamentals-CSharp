namespace _02.Match_Phone_Number
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+\b359(-| )2\1(\d{3}\1\d{4})\b";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            string[] result = matches
                .Select(x => x.Value)
                .ToArray();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
