using System;

namespace PizzaCalories
{
    class Topping
    {
        private double weight;
        private string type;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{Type} weight should be in the range [1..50].");
                }

                weight = value;
            }
        }

        public string Type
        {
            get { return type; }
            set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                type = value;
            }
        }

        public double ToppingCalories { get => this.CalculateCalories(); }

        public double CalculateCalories()
        {
            double calories = 2.0 * this.Weight;

            switch (this.Type.ToLower())
            {
                case "meat":
                    calories *= 1.2;
                    break;
                case "veggies":
                    calories *= 0.8;
                    break;
                case "cheese":
                    calories *= 1.1;
                    break;
                case "sauce":
                    calories *= 0.9;
                    break;
            }

            return calories;
        }
    }
}
