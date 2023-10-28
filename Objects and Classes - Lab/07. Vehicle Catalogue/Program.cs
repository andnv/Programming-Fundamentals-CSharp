namespace _07._Vehicle_Catalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            Catalog catalog = new Catalog();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] vehicleInfo = input.Split('/', StringSplitOptions.RemoveEmptyEntries);

                string type = vehicleInfo[0];
                string brand = vehicleInfo[1];
                string model = vehicleInfo[2];  
                int value = int.Parse(vehicleInfo[3]);

                if (type == "Truck")
                {
                    Truck truck = new Truck(brand, model, value);
                    catalog.Trucks.Add(truck);
                }
                else if (type == "Car")
                {
                    Car car = new Car(brand, model, value);
                    catalog.Cars.Add(car);
                }
            }

            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars: ");
                
                foreach (Car car in catalog.Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks: ");

                foreach (Truck truck in catalog.Trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }

    public class Catalog
    {
        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; set; }

        public List<Truck> Trucks { get; set; }
    }

    public class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }
    }

    public class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }
    }
}
