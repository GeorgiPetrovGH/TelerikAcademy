using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    public class Worker : Human
    {
        private double weekSalary;
        private double workingHours;

        public double WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Weekly Salary must be positive number.");
                }
                this.weekSalary = value;
            }
        }

        public double WorkingHours
        {
            get { return this.workingHours; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Working hours must be greater than zero.");
                }
                this.workingHours = value;
            }
        }

        public Worker(string firstName, string lastName, double weekSalary, double workingHours) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.workingHours = workingHours;
        }

        public double MoneyPerHour()
        {
            double moneyPerHour = this.WeekSalary / this.WorkingHours * 5;
            return moneyPerHour;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1:F2}", base.ToString(), this.MoneyPerHour());
        }
    }
}
