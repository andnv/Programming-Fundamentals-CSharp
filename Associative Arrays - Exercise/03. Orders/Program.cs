namespace _03._Orders
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> totalCollection 
                = new Dictionary<string, List<decimal>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] inputArgs = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = inputArgs[0];
                decimal price = decimal.Parse(inputArgs[1]);
                int quantity = int.Parse(inputArgs[2]);

                if (!totalCollection.ContainsKey(name))
                {
                    totalCollection[name] = new List<decimal>() {0, 0};
                }

                totalCollection[name][0] = price;
                totalCollection[name][1] += quantity;
            }

            foreach (var item in totalCollection)
            {
                decimal totalPrice = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {totalPrice:F2}");
            }
        }
    }
}
