namespace _03._Speed_Racing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    internal class Program
    {
        static void Main(string[] args)
        { 
            int carsNum = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < carsNum; i++)
            {
                string[] carsInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = carsInfo[0];
                int fuelAmount = int.Parse(carsInfo[1]);
                double fuelConsumptionForKilometer = double.Parse(carsInfo[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionForKilometer);
                cars.Add(car);  

            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] commandArgs = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string carModel = commandArgs[1];
                int distance = int.Parse(commandArgs[2]);

                cars.Where(c => c.Model == carModel)
                    .ToList()
                    .ForEach(c => c.Drive(distance));
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }

    public class Car
    {
        private readonly List<Car> cars = new List<Car>();

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = 0;
        }

        public List<Car> Cars
            => this.cars;

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public int TravelledDistance { get; set; }

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

        public void Drive(int distance)
        {
            if (FuelAmount < distance * FuelConsumptionPerKilometer)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                FuelAmount -= distance * FuelConsumptionPerKilometer;
                TravelledDistance += distance;
            }
        }
    }
}
