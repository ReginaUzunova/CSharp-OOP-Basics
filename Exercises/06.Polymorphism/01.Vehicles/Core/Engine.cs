using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Vehicles;
using Vehicles.Vehicles.Contracts;

namespace Vehicles.Core
{
    public class Engine
    {
        public void Run()
        {
            string[] carInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();

            double carFuelQuantity = double.Parse(carInfo[1]);
            double carFuelConsumtion = double.Parse(carInfo[2]);

            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckFuelConsumtion = double.Parse(truckInfo[2]);

            int numberOfCommands = int.Parse(Console.ReadLine());

            Vehicle car = new Car(carFuelQuantity, carFuelConsumtion);
            Vehicle truck = new Truck(truckFuelQuantity, truckFuelConsumtion);

            for (int i = 0; i < numberOfCommands; i++)
            {
                try
                {
                    string[] commandInput = Console.ReadLine().Split();
                    string command = commandInput[0];
                    string vehicle = commandInput[1];
                    double value = double.Parse(commandInput[2]);

                    if (command == "Drive")
                    {
                        if (vehicle == "Car")
                        {
                            car.Drive(value);
                        }
                        else
                        {
                            truck.Drive(value);
                        }
                    }
                    else
                    {
                        if (vehicle == "Car")
                        {
                            car.Refuel(value);
                        }
                        else
                        {
                            truck.Refuel(value);
                        }
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}
