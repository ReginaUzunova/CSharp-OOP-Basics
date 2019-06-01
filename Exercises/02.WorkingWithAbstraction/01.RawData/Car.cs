using System.Collections.Generic;

namespace RawData
{
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tire tire;

        public Car(string model, Engine engine, Cargo cargo, Tire tire)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tire = tire;
        }

        public string Model { get => model; set => model = value; }

        public Engine Engine { get => engine; set => engine = value; }

        public Cargo Cargo { get => cargo; set => cargo = value; }
        
        public Tire Tire { get => tire; set => tire = value; }
    }
}
