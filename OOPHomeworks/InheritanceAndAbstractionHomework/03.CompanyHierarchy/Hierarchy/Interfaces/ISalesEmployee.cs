namespace _03.CompanyHierarchy.Hierarchy.Interfaces
{
    using System.Collections.Generic;

    public interface ISalesEmployee : IRegularEmployee
    {
        List<Sale> Sale { get; set; }
    }
}