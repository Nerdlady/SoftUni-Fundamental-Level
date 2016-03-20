namespace _03.CompanyHierarchy.Hierarchy
{
    using System.Collections.Generic;

    public interface IManager : IEmployee
    {
        List<Employee> Employees { get; set; }
    }
}