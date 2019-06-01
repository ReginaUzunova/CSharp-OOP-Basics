using System;

namespace PizzaCalories
{
    class Dough
    {
        private double weight;
        private string flourType;
        private string bakingTechnique;

        public Dough(string flourType, double weight, string bakingTechnique)
        {
            this.FlourType = flourType;
            this.Weight = weight;
            this.BakingTechnique = bakingTechnique;
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value < 0 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range[1..200].");
                }

                weight = value;
            }
        }
        
        public string FlourType
        {
            get { return flourType; }
            set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                flourType = value;
            }
        }

        public string BakingTechnique
        {
            get { return bakingTechnique; }
            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                bakingTechnique = value;
            }
        }

        public double DoughCalories { get => this.CalculateCalories(); }

        public double CalculateCalories()
        {
            double calories = 2.0 * this.Weight;

            switch (this.FlourType.ToLower())
            {
                case "white":
                    calories *= 1.5;
                    break;
                case "wholegrain":
                    calories *= 1.0;
                    break;
            }
            switch (this.BakingTechnique.ToLower())
            {
                case "crispy":
                    calories *= 0.9;
                    break;
                case "chewy":
                    calories *= 1.1;
                    break;
                case "homemade":
                    calories *= 1.0;
                    break;
            }

            return calories;
        }
    }
}
