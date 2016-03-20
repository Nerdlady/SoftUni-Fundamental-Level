namespace _03.CompanyHierarchy.Hierarchy.Interfaces
{
    using System;

    public interface IProject
    {
        string ProjectName { get; set; }

        DateTime ProjectDate { get; set; }

        string ProjectDetails { get; set; }

        string State { get; set; }

        void CloseProject();
    }
}