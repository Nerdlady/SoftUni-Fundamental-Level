namespace _03.CompanyHierarchy.Hierarchy
{
    using System.Collections.Generic;
    using System.Text;

    public class Manager : Employee, IManager
    {
        public Manager(
            string firstName, 
            string lastName, 
            string id, 
            decimal salary, 
            string department, 
            List<Employee> employees)
            : base(firstName, lastName, id, salary, department)
        {
            this.Employees = employees;
        }

        public List<Employee> Employees { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("\nEmployees under his command:\n");
            foreach (var print in this.Employees)
            {
                output.AppendFormat(print + "\n");
            }

            return base.ToString() + output;
        }
    }
}