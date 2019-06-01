using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Cargo
    {
        private string cargoType;
        private int cargoWeight;

        public Cargo(int cargoWeight, string cargoType)
        {
            this.CargoWeight = cargoWeight;
            this.CargoType = cargoType;
        }
        public string CargoType
        {
            get { return this.cargoType; }
            set { this.cargoType = value; }
        }

        public int CargoWeight
        {
            get { return this.cargoWeight; }
            set { this.cargoWeight = value; }
        }
    }
}
