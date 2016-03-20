namespace _03.CompanyHierarchy.Hierarchy
{
    using _03.CompanyHierarchy.Hierarchy.Interfaces;

    public abstract class RegularEmployee : Employee, IRegularEmployee
    {
        public RegularEmployee(string firstName, string lastName, string id, decimal salary, string department)
            : base(firstName, lastName, id, salary, department)
        {
        }
    }
}