namespace _03.CompanyHierarchy.Hierarchy
{
    using System.Collections.Generic;
    using System.Text;

    using _03.CompanyHierarchy.Hierarchy.Interfaces;

    internal class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        public SalesEmployee(
            string firstName, 
            string lastName, 
            string id, 
            decimal salary, 
            string department, 
            List<Sale> sale)
            : base(firstName, lastName, id, salary, department)
        {
            this.Sale = sale;
        }

        public List<Sale> Sale { get; set; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("\nSales:\n");
            foreach (var print in this.Sale)
            {
                output.AppendFormat(print + "\n");
            }

            return base.ToString() + output;
        }
    }
}