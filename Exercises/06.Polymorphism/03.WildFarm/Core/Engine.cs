using System;
using System.Collections.Generic;
using WildFarm.Animals;
using WildFarm.Animals.Birds.Factory;
using WildFarm.Animals.Contracts;
using WildFarm.Animals.Feline.Factory;
using WildFarm.Animals.Mammals.Factory;
using WildFarm.Foods;
using WildFarm.Foods.Factory;

namespace WildFarm.Core
{
    public class Engine
    {
        private BirdFactory birdFactory;
        private FelineFactory felineFactory;
        private MammalFactory mammalFactory;
        private FoodFactory foodFactory;
        private List<IAnimal> animals;
        private Animal animal;

        public Engine()
        {
            this.birdFactory = new BirdFactory();
            this.felineFactory = new FelineFactory();
            this.mammalFactory = new MammalFactory();
            this.foodFactory = new FoodFactory();
            this.animals = new List<IAnimal>();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {

                string[] animalInfo = input.Split();
                string[] foodInfo = Console.ReadLine().Split();

                string animalType = animalInfo[0];
                string name = animalInfo[1];
                double weight = double.Parse(animalInfo[2]);

                if (animalType == "Hen" || animalType == "Owl")
                {
                    double wingSize = double.Parse(animalInfo[3]);
                    animal = this.birdFactory.CreateBird(animalType, name, weight, wingSize);
                }
                else if (animalType == "Mouse" || animalType == "Dog")
                {
                    string livingRegion = animalInfo[3];
                    animal = this.mammalFactory.CreateMammal(animalType, name, weight, livingRegion);
                }
                else if (animalType == "Cat" || animalType == "Tiger")
                {
                    string livingRegion = animalInfo[3];
                    string breed = animalInfo[4];

                    animal = this.felineFactory.CreateFeline(animalType, name, weight, livingRegion, breed);
                }

                string foodType = foodInfo[0];
                int quantity = int.Parse(foodInfo[1]);
                Food food = this.foodFactory.CreateFood(foodType, quantity);

                animal.ProduceSound();
                animal.Eat(food);
                animals.Add(animal);

                input = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
