using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Tire
    {
        private double[] tiresPressure;
        private int[] tiresAge;

        public Tire(double[] tiresPressure, int[] tiresAge)
        {
            this.TiresPressure = tiresPressure;
            this.TiresAge = tiresAge;
        }

        public double[] TiresPressure
        {
            get { return this.tiresPressure; }
            set { this.tiresPressure = value; }
        }

        public int[] TiresAge
        {
            get { return this.tiresAge; }
            set { this.tiresAge = value; }
        }
    }
}
