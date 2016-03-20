namespace _03.CompanyHierarchy.Hierarchy
{
    using System;

    public class Employee : Person, IEmployee
    {
        private string department;

        private decimal salary;

        public Employee(string firstName, string lastName, string id, decimal salary, string department)
            : base(firstName, lastName, id)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negative");
                }

                this.salary = value;
            }
        }

        public string Department
        {
            get
            {
                return this.department;
            }

            set
            {
                switch (value.ToLower())
                {
                    case "production":
                    case "accounting":
                    case "sales":
                    case "marketing":
                        this.department = value;
                        break;
                    default:
                        throw new ArgumentException(
                            "The department can only be one of the following: Production, Accounting, Sales or Marketing.");
                }
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Salary: {0}lv, Department: {1}", this.Salary, this.Department);
        }
    }
}