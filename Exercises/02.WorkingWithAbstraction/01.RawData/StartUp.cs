using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string model = parameters[0];

                int engineSpeed = int.Parse(parameters[1]);
                int enginePower = int.Parse(parameters[2]);

                int cargoWeight = int.Parse(parameters[3]);
                string cargoType = parameters[4];

                double[] tirePressures = { double.Parse(parameters[5]), double.Parse(parameters[7]), double.Parse(parameters[9]), double.Parse(parameters[11]) }; ;
                int[] tireages = { int.Parse(parameters[6]), int.Parse(parameters[8]), int.Parse(parameters[10]), int.Parse(parameters[12]) };

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Tire tire = new Tire(tirePressures, tireages);
                Car car = new Car(model, engine, cargo, tire);

                cars.Add(car);
            }

            string command = Console.ReadLine();

            List<string> result = new List<string>();

            if (command == "fragile")
            {
                result = cars
                    .Where(x => x.Cargo.Type == "fragile" && x.Tire.Pressure.Any(y => y < 1))
                    .Select(x => x.Model)
                    .ToList();
            }
            else
            {
                result = cars
                    .Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250)
                    .Select(x => x.Model)
                    .ToList();
            }

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
