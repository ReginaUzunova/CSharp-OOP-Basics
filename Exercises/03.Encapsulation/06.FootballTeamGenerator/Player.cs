using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    class Player
    {
        private string name;
        private List<Stat> stats;
        private double averageSkillLevel;

        public Player(string name)
        {
            this.Name = name;
            this.Stats = new List<Stat>();
            this.AverageSkillLevel = 0;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                name = value;
            }
        }

        public List<Stat> Stats
        {
            get { return stats; }
            set { stats = value; }
        }
        

        public double AverageSkillLevel
        {
            get { return CalculateSkillLevel(); }
            set { averageSkillLevel = value; }
        }


        public void AddStats(Stat stat)
        {
            Stats.Add(stat);
        }

        public double CalculateSkillLevel()
        {
            double averageSkillLevel = this.Stats.Sum(s => s.Level) / 5.0;
            return averageSkillLevel;
        }
    }
}
