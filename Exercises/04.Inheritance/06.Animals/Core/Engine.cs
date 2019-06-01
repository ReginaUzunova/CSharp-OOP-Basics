using Animals.Animals1;
using Animals.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Core
{
    public class Engine
    {
        private AnimalFactory animalFactory;
        private List<Animal> animals;

        public Engine()
        {
            this.animalFactory = new AnimalFactory();
            this.animals = new List<Animal>();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "Beast!")
            {
                try
                {
                    string animalType = input;
                    string[] inputInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    string name = inputInfo[0];
                    int age = int.Parse(inputInfo[1]);
                    string gender = inputInfo[2];

                    Animal animal = animalFactory.CreateAnimal(animalType, name, age, gender);
                    animals.Add(animal);
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine();
            }

            Print();
        }

        private void Print()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine(animal);
                animal.ProduceSound();
            }
        }
    }
}
