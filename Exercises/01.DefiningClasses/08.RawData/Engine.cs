using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Engine
    {
        private int enginePower;
        private int engineSpeed;

        public Engine(int engineSpeed, int enginePower)
        {
            this.EngineSpeed = engineSpeed;
            this.EnginePower = enginePower;
        }
        public int EnginePower
        {
            get { return this.enginePower; }
            set { this.enginePower = value; }
        }

        public int EngineSpeed
        {
            get { return this.engineSpeed; }
            set { this.engineSpeed = value; }
        }
    }
}
