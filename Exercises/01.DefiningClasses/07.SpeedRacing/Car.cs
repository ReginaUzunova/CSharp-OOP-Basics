using System;
using System.Collections.Generic;
using System.Text;

namespace _07.SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumption;
        private int traveledDistance;
        private int amountOfKm;

        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumption = fuelConsumption;
            this.TraveledDistance = 0;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public double FuelAmount
        {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }

        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }

        public int TraveledDistance
        {
            get { return this.traveledDistance; }
            set { this.traveledDistance = value; }
        }

        public int AmountOfKm
        {
            get { return this.amountOfKm; }
            set { this.amountOfKm = value; }
        }

        public void CalculateMove(int amountOfKm)
        {
            double neededFuel = amountOfKm * this.fuelConsumption;

            if (this.fuelAmount < neededFuel)
            {
                Console.WriteLine("Insufficient fuel for the drive");
                return;
            }

            this.fuelAmount -= neededFuel;
            this.traveledDistance += amountOfKm;
        }
    }
}
