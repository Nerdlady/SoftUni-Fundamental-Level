﻿namespace _03.CompanyHierarchy.Hierarchy.Interfaces
{
    using System;

    public interface ISale
    {
        string ProductName { get; set; }

        DateTime Date { get; set; }

        decimal Price { get; set; }
    }
}