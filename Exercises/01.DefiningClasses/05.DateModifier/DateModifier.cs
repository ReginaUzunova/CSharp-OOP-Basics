using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace DefiningClasses
{
    public class DateModifier
    {
        private string startDate;
        private string endDate;

        public DateModifier(string startDate, string endDate)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public string StartDate
        {
            get { return this.startDate; }
            set { this.startDate = value; }
        }

        public string EndDate
        {
            get { return this.endDate; }
            set { this.endDate = value; }
        }

        public double CalculateDifference(string startDate, string endDate)
        {
            double difference = Math.Abs((Convert.ToDateTime(startDate) - Convert.ToDateTime(endDate)).TotalDays);
            return difference;
        }
    }
}
