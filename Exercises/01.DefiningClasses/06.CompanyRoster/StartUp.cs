using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                decimal salary = decimal.Parse(input[1]);
                string position = input[2];
                string department = input[3];
                string email = "";
                int age = 0;

                Employee employee = new Employee(name, salary, position, department);

                if (input.Length == 5)
                {
                    if (input[4].Length < 3)
                    {
                        age = int.Parse(input[4]);
                        employee.Age = age;
                    }
                    else
                    {
                        email = input[4];
                        employee.Email = email;
                    }
                }
                else if (input.Length == 6)
                {
                    email = input[4];
                    age = int.Parse(input[5]);
                    employee.Email = email;
                    employee.Age = age;
                }

                employees.Add(employee);
            }

            var topDepartment = employees.GroupBy(x => x.Department)
                .ToDictionary(x => x.Key, y => y.Select(s => s))
                .OrderByDescending(x => x.Value.Average(s => s.Salary))
                .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {topDepartment.Key}");

            foreach (var employee in topDepartment.Value.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }
        }
    }
}
