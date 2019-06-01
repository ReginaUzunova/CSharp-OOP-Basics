using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension.Vehicles
{
    public class Bus : Vehicle
    {
        private const double airConditionConsumption = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            double currentFuelConsumtion = this.FuelConsumption;

            if (IsVehicleEmpty == false)
            {
                currentFuelConsumtion += airConditionConsumption;
            }

            double neededFuel = distance * currentFuelConsumtion;

            if (this.FuelQuantity < neededFuel)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }

            this.FuelQuantity -= neededFuel;
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }

    }
}
