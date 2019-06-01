using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            PollMembers family = new PollMembers();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);
                family.AddMember(person);
            }

            foreach (var name in family.Members.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{name.Name} - {name.Age}");
            }
        }
    }
}
