using System;
using VehiclesExtension.Vehicles;
using VehiclesExtension.Vehicles.Contracts;

namespace VehiclesExtension.Core
{
    public class Engine
    {
        public void Run()
        {
            string[] carInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();
            string[] busInfo = Console.ReadLine().Split();

            double carFuelQuantity = double.Parse(carInfo[1]);
            double carFuelConsumtion = double.Parse(carInfo[2]);
            double carTaknCapacity = double.Parse(carInfo[3]);

            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckFuelConsumtion = double.Parse(truckInfo[2]);
            double truckTaknCapacity = double.Parse(truckInfo[3]);

            double busFuelQuantity = double.Parse(busInfo[1]);
            double busFuelConsumtion = double.Parse(busInfo[2]);
            double busTaknCapacity = double.Parse(busInfo[3]);

            int numberOfCommands = int.Parse(Console.ReadLine());

            IVehicle car = new Car(carFuelQuantity, carFuelConsumtion, carTaknCapacity);
            IVehicle truck = new Truck(truckFuelQuantity, truckFuelConsumtion, truckTaknCapacity);
            IVehicle bus = new Bus(busFuelQuantity, busFuelConsumtion, busTaknCapacity);

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
                        else if (vehicle == "Bus")
                        {
                            bus.IsVehicleEmpty = false;
                            bus.Drive(value);
                        }
                        else
                        {
                            truck.Drive(value);
                        }
                    }
                    else if (command == "DriveEmpty")
                    {
                        bus.IsVehicleEmpty = true;
                        bus.Drive(value);
                    }
                    else
                    {
                        if (vehicle == "Car")
                        {
                            car.Refuel(value);
                        }
                        else if (vehicle == "Bus")
                        {
                            bus.Refuel(value);
                        }
                        else
                        {
                            truck.Refuel(value);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
