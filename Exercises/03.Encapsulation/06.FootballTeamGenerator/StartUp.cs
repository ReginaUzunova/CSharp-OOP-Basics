using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

            List<Team> teams = new List<Team>();

            while (command[0] != "END")
            {
                try
                {
                    string teamName = command[1];

                    if (command[0] == "Team")
                    {
                        Team team = new Team(teamName);
                        teams.Add(team);
                    }
                    else if (command[0] == "Add")
                    {
                        string playerName = command[2];

                        Player player = new Player(playerName);

                        if (IsTeamExist(teams, teamName))
                        {
                            string[] statsNames = { "Endurance", "Sprint", "Dribble", "Passing", "Shoting" };
                            int counter = 0;

                            for (int i = 3; i < command.Length; i++)
                            {
                                Stat stat = new Stat(statsNames[counter++], int.Parse(command[i]));
                                player.AddStats(stat);
                            }

                            teams.First(t => t.Name == teamName).AddPlayer(player);
                        }
                        else
                        {
                            throw new Exception($"Team {teamName} does not exist.");
                        }
                    }
                    else if (command[0] == "Remove")
                    {
                        string playerName = command[2];

                        teams.First(t => t.Name == teamName).RemovePlayer(playerName);
                    }
                    else
                    {
                        if (IsTeamExist(teams, teamName))
                        {
                            Console.WriteLine($"{teamName} - {teams.First(t => t.Name == teamName).Rating}");
                        }
                        else
                        {
                            throw new Exception($"Team {teamName} does not exist.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                

                command = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            }
        }

        public static bool IsTeamExist(List<Team> teams, string teamName)
        {
            return teams.Exists(x => x.Name == teamName);
        }
    }
}
