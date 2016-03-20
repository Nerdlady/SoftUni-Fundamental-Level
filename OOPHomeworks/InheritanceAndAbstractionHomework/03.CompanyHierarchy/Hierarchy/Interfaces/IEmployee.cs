namespace _03.CompanyHierarchy.Hierarchy
{
    public interface IEmployee : IPerson
    {
        decimal Salary { get; set; }

        string Department { get; set; }
    }
}