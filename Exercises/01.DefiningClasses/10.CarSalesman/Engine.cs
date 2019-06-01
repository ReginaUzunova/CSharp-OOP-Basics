using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        private string model;
        private string power;
        private string displacement;
        private string efficiency;

        public Engine(string model, string power)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = "n/a";
            this.Efficiency = "n/a";
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        
        public string Power
        {
            get { return power; }
            set { power = value; }
        }
       
        public string Displacement
        {
            get { return displacement; }
            set { displacement = value; }
        }

        public string Efficiency
        {
            get { return efficiency; }
            set { efficiency = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"  {this.Model}:\n");
            sb.Append($"    Power: {this.Power}\n");
            sb.Append($"    Displacement: {this.Displacement}\n");
            sb.Append($"    Efficiency: {this.Efficiency}\n");

            return sb.ToString();
        }
    }
}
