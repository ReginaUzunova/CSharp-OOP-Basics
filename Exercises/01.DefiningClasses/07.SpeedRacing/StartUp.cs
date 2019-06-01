using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.SpeedRacing
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string carModel = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumption = double.Parse(input[2]);

                Car car = new Car(carModel, fuelAmount, fuelConsumption);

                cars.Add(car);
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                string carToDrive = command[1];
                int amountOfKm = int.Parse(command[2]);

                Car currentCar = cars.Where(c => c.Model == carToDrive).FirstOrDefault();

                currentCar.CalculateMove(amountOfKm);

                command = Console.ReadLine().Split();
            }

            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:F2} {item.TraveledDistance}");
            }
        }
    }
}
