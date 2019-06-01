using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCalories
{
    class Pizza
    {
        private string name;
        private List<Topping> toppings;
        private Dough dough;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Toppings = new List<Topping>();
            this.Dough = dough;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                name = value;
            }
        }

        public List<Topping> Toppings
        {
            get { return toppings; }
            set { toppings = value; }
        }

        public Dough Dough
        {
            get { return dough; }
            set { dough = value; }
        }

        public void AddTopping(Topping topping)
        {
            if (toppings.Count > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            this.Toppings.Add(topping);
        }

        public double CalculatePizzaCalories()
        {
            double allCalories = this.Dough.DoughCalories + this.Toppings.Sum(x => x.ToppingCalories);

            return allCalories;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.CalculatePizzaCalories():F2} Calories.";
        }
    }
}
