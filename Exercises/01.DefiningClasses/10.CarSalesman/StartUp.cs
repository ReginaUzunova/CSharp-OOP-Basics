using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            int engineCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < engineCount; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string engineModel = engineInfo[0];
                string enginePower = engineInfo[1];

                Engine engine = new Engine(engineModel, enginePower);

                if (engineInfo.Length == 3)
                {
                    if (int.TryParse(engineInfo[2], out int result))
                    {
                        string displacement = engineInfo[2];
                        engine.Displacement = displacement;
                    }
                    else
                    {
                        string efficiency = engineInfo[2];
                        engine.Efficiency = efficiency;
                    }
                }
                else if (engineInfo.Length == 4)
                {
                    string displacement = engineInfo[2];
                    string efficiency = engineInfo[3];
                    engine.Displacement = displacement;
                    engine.Efficiency = efficiency;
                }

                engines.Add(engine);
            }

            int carCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carCount; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string carModel = carInfo[0];
                string engineModel = carInfo[1];

                Car car = new Car(carModel, engines.Where(e => e.Model == engineModel).FirstOrDefault());

                if (carInfo.Length == 3)
                {
                    if (int.TryParse(carInfo[2], out int result))
                    {
                        string weight = carInfo[2];
                        car.Weight = weight;
                    }
                    else
                    {
                        string color = carInfo[2];
                        car.Color = color;
                    }
                }
                else if (carInfo.Length == 4)
                {
                    string weight = carInfo[2];
                    string color = carInfo[3];
                    car.Weight = weight;
                    car.Color = color;
                }

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
