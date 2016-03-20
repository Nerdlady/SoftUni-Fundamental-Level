namespace _03.CompanyHierarchy.Hierarchy
{
    using System.Collections.Generic;

    using _03.CompanyHierarchy.Hierarchy.Interfaces;

    public interface IDeveloper : IRegularEmployee
    {
        List<Project> Project { get; set; }
    }
}