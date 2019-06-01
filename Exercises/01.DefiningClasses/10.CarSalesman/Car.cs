﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private string weight;
        private string color;

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = "n/a";
            this.Color = "n/a";
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
       
        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }
        
        public string Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Model}:\n");
            sb.Append(this.Engine.ToString());
            sb.Append($"  Weight: {this.Weight}\n");
            sb.Append($"  Color: {this.Color}");

            return sb.ToString();
        }
    }
}
