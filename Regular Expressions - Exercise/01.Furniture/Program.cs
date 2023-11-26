namespace _01.Furniture
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> furnitures = new List<string>();

            string pattern = @"^>>(?<furnitureName>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)(\.\d+)?$";
            Regex regex = new Regex(pattern);

            double totalMoneySpend = 0;

            string inputLine = string.Empty;

            while ((inputLine = Console.ReadLine()) != "Purchase")
            {
                Match match = regex.Match(inputLine);
                if (match.Success)
                {
                    string furnitureName = match.Groups["furnitureName"].Value;
                    double pricePerUnit = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    furnitures.Add(furnitureName);
                    totalMoneySpend += pricePerUnit * quantity;
                }
            }

            Console.WriteLine($"Bought furniture: ");

            foreach (string furnitureName in furnitures)
            {
                Console.WriteLine(furnitureName);
            }
            Console.WriteLine($"Total money spend: {totalMoneySpend:F2}");
        }
    }
}
