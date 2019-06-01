using System;

namespace Mankind
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] studentInfo = Console.ReadLine().Split();
            string[] workerInfo = Console.ReadLine().Split();

            string studentFirstName = studentInfo[0];
            string studentLastName = studentInfo[1];
            string facultyNumber = studentInfo[2];

            string workerFirstName = workerInfo[0];
            string workerLastName = workerInfo[1];
            decimal weekSalary = decimal.Parse(workerInfo[2]);
            double workingHours = double.Parse(workerInfo[3]);

            try
            {
                Student student = new Student(studentFirstName, studentLastName, facultyNumber);
                Worker worker = new Worker(workerFirstName, workerLastName, weekSalary, workingHours);

                Console.WriteLine(student.ToString());
                Console.WriteLine(worker.ToString());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
