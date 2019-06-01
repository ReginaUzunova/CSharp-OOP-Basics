using System;

namespace Mankind
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private double workingHours;

        public Worker(string firstName, string lastName, decimal weekSalary, double workingHours) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkingHours = workingHours;
        }

        public decimal WeekSalary
        {
            get { return weekSalary; }
            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }

                weekSalary = value;
            }
        }

        public double WorkingHours
        {
            get { return workingHours; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }

                workingHours = value;
            }
        }

        private decimal CalculateSalaryPerHour()
        {
            decimal salaryPerHour = this.WeekSalary / (decimal)(this.WorkingHours * 5.0);
            return salaryPerHour;
        }

        public override string ToString()
        {
            return $"First Name: {this.FirstName}\n" +
                $"Last Name: {this.LastName}\n" +
                $"Week Salary: {this.WeekSalary:F2}\n" +
                $"Hours per day: {this.WorkingHours:F2}\n" +
                $"Salary per hour: {this.CalculateSalaryPerHour():F2}";
        }
    }
}
