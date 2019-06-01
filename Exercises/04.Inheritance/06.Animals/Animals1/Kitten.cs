using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Animals1
{
    public class Kitten : Cat
    {
        public const string gender = "Female";

        public Kitten(string name, int age) : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
