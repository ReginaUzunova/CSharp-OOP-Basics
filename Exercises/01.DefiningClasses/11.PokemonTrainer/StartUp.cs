using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();
            
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "Tournament")
            {
                string trainerName = input[0];
                string pokemonName = input[1];
                string pokemonElement = input[2];
                int pokemonHealth = int.Parse(input[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                bool wasAdded = false;
                Trainer trainer = GetTrainer(trainers, trainerName, pokemon, wasAdded);

                if (wasAdded == false)
                {
                    trainers.Add(trainer);
                }

                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            string element = Console.ReadLine();

            //while (element != "End")
            //{
            //    trainers.Select(x => x.Pokemon.Element == element);
                
            //    if (trainers.Select(x => x.Pokemon.Element == element).)
            //    {
            //        trainer.
            //    }

            //    element = Console.ReadLine();
            //}
        }

        private static Trainer GetTrainer(List<Trainer> trainers, string trainerName, Pokemon pokemon, bool wasAdded)
        {
            Trainer trainer = new Trainer(trainerName);

            trainer.Pokemon.Add(pokemon);

            foreach (var item in trainers)
            {
                if (item.Name == trainerName)
                {
                    trainer.Pokemon.Add(pokemon);
                    wasAdded = true;
                    break;
                }
            }
            
            return trainer;
        }
    }
}
