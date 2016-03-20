namespace _03.CompanyHierarchy.Hierarchy
{
    using System.Collections.Generic;
    using System.Text;

    public class Developer : RegularEmployee, IDeveloper
    {
        public Developer(
            string firstName, 
            string lastName, 
            string id, 
            decimal salary, 
            string department, 
            List<Project> project)
            : base(firstName, lastName, id, salary, department)
        {
            this.Project = project;
        }

        public List<Project> Project { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("\nProjects:\n");
            foreach (var print in this.Project)
            {
                output.AppendFormat(print + "\n");
            }

            return base.ToString() + output;
        }
    }
}