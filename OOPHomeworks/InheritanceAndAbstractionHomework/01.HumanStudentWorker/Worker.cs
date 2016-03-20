using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HumanStudentWorker
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;
        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary can't be negative");
                }
                this.weekSalary = value;
            }
        }
        public decimal WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Work hours can't be negative");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour(int workDaysPerWeek)
        {
            decimal money = WeekSalary  /  (WorkHoursPerDay * workDaysPerWeek);
            return money;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("Week Salary: {0}, " , this.WeekSalary, Environment.NewLine);
            output.AppendFormat("Work Hours Per Day: {0}, " , this.WorkHoursPerDay , Environment.NewLine);
            return base.ToString() + output;
        }
    }
}
