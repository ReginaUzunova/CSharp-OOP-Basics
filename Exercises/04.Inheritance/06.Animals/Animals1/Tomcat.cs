using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Animals1
{
    public class Tomcat : Cat
    {
        public const string gender = "Male";

        public Tomcat(string name, int age) : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("MEOW");
        }
    }
}
