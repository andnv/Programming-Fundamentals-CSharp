namespace _04._SoftUni_Parking
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks.Sources;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> usersData 
                = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries);

                string command = commandArgs[0];
 
                if (command == "register")
                {
                    string username = commandArgs[1];
                    string licensePlateNumber = commandArgs[2];

                    if (!usersData.ContainsKey(username))
                    {
                        usersData[username] = licensePlateNumber;
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                }
                else if (command == "unregister")
                {
                    string username = commandArgs[1];

                    if (!usersData.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        usersData.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var  user in usersData)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
