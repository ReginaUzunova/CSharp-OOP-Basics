

using System;

namespace VehiclesExtension.Vehicles
{
    public class Truck : Vehicle
    {
        private const double airConditionConsumption = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.FuelConsumption += airConditionConsumption;
        }

        public override void Refuel(double fuel)
        {
            double availableSpace = this.TankCapacity - this.FuelQuantity;

            if (fuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (fuel > availableSpace)
            {
                throw new Exception($"Cannot fit {fuel} fuel in the tank");
            }

            this.FuelQuantity += fuel * 0.95;
        }
    }
}
