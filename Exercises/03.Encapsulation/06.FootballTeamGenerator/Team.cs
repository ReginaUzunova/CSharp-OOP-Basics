using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    class Team
    {
        private string name;
        private List<Player> players;
        private int rating;

        public Team(string name)
        {
            this.Name = name;
            this.Players = new List<Player>();
            this.Rating = 0;
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
       
        public List<Player> Players
        {
            get { return players; }
            set { players = value; }
        }

        public int Rating
        {
            get { return CalculateRating(); }
            set { rating = value; }
        }

        public void AddPlayer(Player player)
        {
            this.Players.Add(player);
        }

        public void RemovePlayer(string player)
        {
            Player currentPlayer = this.Players.FirstOrDefault(p => p.Name == player);

            if (currentPlayer == null)
            {
                throw new Exception($"Player {player} is not in {this.Name} team.");
            }

            Players.Remove(currentPlayer);
        }

        public int CalculateRating()
        {
            if (this.Players.Any())
            {
                int teamRating = (int)Math.Round(this.Players.Sum(x => x.AverageSkillLevel) / Players.Count);

                return teamRating;
            }
            else
            {
                return 0;
            }
        }
    }
}
