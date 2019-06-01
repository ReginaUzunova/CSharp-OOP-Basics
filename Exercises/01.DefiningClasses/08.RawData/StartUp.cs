using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
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

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                double[] tiresPressure = { double.Parse(input[5]), double.Parse(input[7]), double.Parse(input[9]), double.Parse(input[11]) };
                int[] tiresAge = { int.Parse(input[6]), int.Parse(input[8]), int.Parse(input[10]), int.Parse(input[12]) };

                Engine engine = new Engine(engineSpeed, enginePower);

                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Tire tire = new Tire(tiresPressure, tiresAge);

                Car car = new Car(model, engine, cargo, tire);

                cars.Add(car);

            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var item in cars.Where(c => c.Cargo.CargoType == "fragile").Where(c => c.Tire.TiresPressure.Any(x => x < 1)))
                {
                    Console.WriteLine(item.Model);
                }
            }
            else
            {
                foreach (var item in cars.Where(c => c.Cargo.CargoType == "flamable").Where(c => c.Engine.EnginePower > 250))
                {
                    Console.WriteLine(item.Model);
                }
            }
        }
    }
}
