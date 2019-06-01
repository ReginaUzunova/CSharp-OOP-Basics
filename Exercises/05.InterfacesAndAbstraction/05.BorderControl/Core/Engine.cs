using BorderControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BorderControl.Core
{
    public class Engine
    {
        public void Run()
        {
            List<Citizen> citizens = new List<Citizen>();
            List<Robot> robots = new List<Robot>();

            string[] input = Console.ReadLine().Split();

            while (input[0] != "End")
            {
                if (input.Length == 3)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string id = input[2];

                    Citizen citizen = new Citizen(name, age, id);
                    citizens.Add(citizen);
                }
                else
                {
                    string model = input[0];
                    string id = input[1];

                    Robot robot = new Robot(model, id);
                    robots.Add(robot);
                }

                input = Console.ReadLine().Split();
            }

            string specialNumber = Console.ReadLine();

            foreach (var robot in robots.Where(x => x.Id.EndsWith(specialNumber)))
            {
                Console.WriteLine(robot.Id);
            }

            foreach (var citizen in citizens.Where(x => x.Id.EndsWith(specialNumber)))
            {
                Console.WriteLine(citizen.Id);
            }
        }
    }
}
