using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    class Stat
    {
        private string name;
        private int level;

        public Stat(string name, int level)
        {
            this.Name = name;
            this.Level = level;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Level
        {
            get { return level; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException($"{this.Name} should be between 0 and 100.");
                }

                level = value;
            }
        }

    }
}
