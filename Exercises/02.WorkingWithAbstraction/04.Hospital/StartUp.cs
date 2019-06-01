using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital
{
    public class StartUp
    {
        static List<Department> departments;
        static List<Doctor> doctors;

        public static void Main()
        {
            departments = new List<Department>();
            doctors = new List<Doctor>();

            string command = Console.ReadLine();
            while (command != "Output")
            {
                string[] tokens = command.Split();
                string departamentName = tokens[0];
                string firstName = tokens[1];
                string lastName = tokens[2];
                string pacient = tokens[3];

                Department department = GetDepartment(departamentName);
                Doctor doctor = GetDoctor(firstName, lastName);

                bool containsFreeSpace = department.Rooms.Sum(x => x.Patients.Count) < 60;

                if (containsFreeSpace)
                {
                    int room = 0;

                    doctor.Patients.Add(pacient);

                    for (int i = 0; i < department.Rooms.Count; i++)
                    {
                        if (department.Rooms[i].Patients.Count < 3)
                        {
                            room = i;
                            break;
                        }
                    }

                    department.Rooms[room].Patients.Add(pacient);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] args = command.Split();

                if (args.Length == 1)
                {
                    Department department = GetDepartment(args[0]);

                    foreach (var room in department.Rooms.Where(x => x.Patients.Count > 0))
                    {
                        foreach (var patient in room.Patients)
                        {
                            Console.WriteLine(patient);
                        }
                    }
                    
                }
                else if (args.Length == 2 && int.TryParse(args[1], out int room))
                {
                    Department department = GetDepartment(args[0]);

                    foreach (var name in department.Rooms[room - 1].Patients.OrderBy(x => x))
                    {
                        Console.WriteLine(name);
                    }
                }
                else
                {
                    string firstName = args[0];
                    string lastName = args[1];

                    Doctor doctor = GetDoctor(firstName, lastName);

                    foreach (var patient in doctor.Patients.OrderBy(x => x))
                    {
                        Console.WriteLine(patient);
                    }
                }

                command = Console.ReadLine();
            }
        }

        private static Doctor GetDoctor(string firstName, string lastName)
        {
            Doctor doctor = doctors.Where(x => x.FirstName == firstName && x.LastName == lastName).FirstOrDefault();

            if (doctor == null)
            {
                doctor = new Doctor(firstName, lastName);
                doctors.Add(doctor);
            }

            return doctor;
        }

        private static Department GetDepartment(string departamentName)
        {
            Department department = departments.Where(x => x.Name == departamentName).FirstOrDefault();

            if (department == null)
            {
                department = new Department(departamentName);
                departments.Add(department);

                for (int i = 0; i < 20; i++)
                {
                    department.Rooms.Add(new Room());
                }
            }

            return department;
        }
    }
}
