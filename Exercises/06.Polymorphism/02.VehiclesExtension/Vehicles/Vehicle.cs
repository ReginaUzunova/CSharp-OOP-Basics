﻿using System;
using VehiclesExtension.Vehicles.Contracts;

namespace VehiclesExtension.Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public bool IsVehicleEmpty { get; set; } 

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set
            {
                if (value > this.TankCapacity)
                {
                    value = 0;
                }

                fuelQuantity = value;
            }
        }

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public double TankCapacity
        {
            get { return tankCapacity; }
            set { tankCapacity = value; }
        }

        public virtual void Drive(double distance)
        {
            double neededFuel = distance * this.FuelConsumption;

            if (this.FuelQuantity < neededFuel)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }
            
            this.FuelQuantity -= neededFuel;
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }

        public virtual void Refuel(double fuel)
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

            this.FuelQuantity += fuel;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}
