using System;

namespace PizzaCalories
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] pizzaInput = Console.ReadLine().Split();
            string pizzaName = pizzaInput[1];

            string[] doughInput = Console.ReadLine().Split();
            string flourType = doughInput[1];
            string bakingTechnique = doughInput[2];
            double doughWeight = double.Parse(doughInput[3]);

            string[] toppingInput = Console.ReadLine().Split();

            try
            {
                Dough dough = new Dough(flourType, doughWeight, bakingTechnique);
                Pizza pizza = new Pizza(pizzaName, dough);

                while (toppingInput[0] != "END")
                {
                    string toppingType = toppingInput[1];
                    double toppingWeight = double.Parse(toppingInput[2]);
                    
                    Topping topping = new Topping(toppingType, toppingWeight);

                    pizza.AddTopping(topping);

                    toppingInput = Console.ReadLine().Split();
                }

                Console.WriteLine(pizza.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
