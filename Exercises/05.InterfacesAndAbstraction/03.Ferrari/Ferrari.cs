using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    public class Ferrari : ICar
    {
        private string driver;

        public Ferrari(string model, string driver)
        {
            this.Model = "488-Spider";
            this.Driver = driver;
        }

        public string Model { get; set; }

        public string Driver
        {
            get { return driver; }
            private set { driver = value; }
        }

        public string Brakes()
        {
            return "Brakes!";
        }

        public string Gas()
        {
            return "Zadu6avam sA!";
        }
    }
}
