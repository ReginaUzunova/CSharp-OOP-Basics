using System;
using System.Collections.Generic;


namespace PokemonTrainer
{
    public class Trainer
    {
        private string name;
        private int badges;
        private List<Pokemon> pokemon;

        public Trainer(string name)
        {
            this.Name = name;
            this.Badges = 0;
            this.Pokemon = new List<Pokemon>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public int Badges
        {
            get { return badges; }
            set { badges = value; }
        }

        public List<Pokemon> Pokemon
        {
            get { return pokemon; }
            set { pokemon = value; }
        }

        //public bool Element(string element)
        //{
        //    if (this.Pokemon.Element == element)
        //    {
        //        return true;
        //    }

        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
