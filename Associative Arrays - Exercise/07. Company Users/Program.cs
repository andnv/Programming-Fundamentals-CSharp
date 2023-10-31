namespace _07._Company_Users
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies 
                = new Dictionary<string, List<string>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string companyName = cmdArgs[0];
                string employeeID = cmdArgs[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                }
                if (!companies[companyName].Contains(employeeID))
                {
                    companies[companyName].Add(employeeID);
                }
            }

            foreach (var company in companies)
            {
                Console.WriteLine(company.Key);

                foreach (var employeeID in company.Value)
                {
                    Console.WriteLine($"-- {employeeID}");
                }
            }
        }
    }
}
