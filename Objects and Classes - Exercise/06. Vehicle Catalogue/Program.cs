namespace _06._Vehicle_Catalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> catalogue = new List<Vehicle>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] vehicleInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string vehicleType = vehicleInfo[0];
                string model = vehicleInfo[1];
                string color = vehicleInfo[2];
                int horsePower = int.Parse(vehicleInfo[3]);

                Vehicle currentVehicle = new Vehicle(vehicleType, model, color, horsePower);
                catalogue.Add(currentVehicle);
            }

            string vehicleModel = string.Empty;

            while ((vehicleModel = Console.ReadLine()) != "Close the Catalogue")
            {
                Console.WriteLine(catalogue.Find(x => x.Model == vehicleModel));
            }

            List<Vehicle> carsOnly = catalogue.Where(x => x.Type == "car").ToList();
            List<Vehicle> trucksOnly = catalogue.Where(x => x.Type == "truck").ToList();

            double totalCarsHorsePower = 0;
            double totalTrucksHorsePower = 0;

            foreach (Vehicle car in carsOnly)
            {
                totalCarsHorsePower += car.HorsePower;
            }

            foreach (Vehicle truck in trucksOnly)
            {
                totalTrucksHorsePower += truck.HorsePower;
            }

            double avgCarsHorsePower = totalCarsHorsePower / carsOnly.Count;
            double avgTrucksHorsePower = totalTrucksHorsePower / trucksOnly.Count;

            if (carsOnly.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {avgCarsHorsePower:F2}.");

            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:F2}.");
            }

            if (trucksOnly.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {avgTrucksHorsePower:F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:F2}.");
            }
        }
    }

    public class Vehicle
    {
        public Vehicle(string vehicleType, string model, string color, int horsePower)
        {
            Type = vehicleType;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public override string ToString()
        {
            string vehicleStr = $"Type: {(Type == "car" ? "Car" : "Truck")}{Environment.NewLine}" +
                                $"Model: {Model}{Environment.NewLine}" +
                                $"Color: {Color}{Environment.NewLine}" +
                                $"Horsepower: {HorsePower}";

            return vehicleStr;
        }
    }
}
