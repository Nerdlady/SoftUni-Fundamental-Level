namespace _03.CompanyHierarchy
{
    using System;
    using System.Collections.Generic;

    using _03.CompanyHierarchy.Hierarchy;

    internal class CompanyHierarchy
    {
        private static void Main()
        {
            SalesEmployee salesEmployee = new SalesEmployee(
                "Pesho", 
                "Petrov", 
                "b02s5", 
                950m, 
                "Sales", 
                new List<Sale>
                    {
                        new Sale("Mouse", DateTime.Parse("2.6.2015"), 12.5m), 
                        new Sale("Laptop", DateTime.Parse("02.10.2015"), 650m)
                    });

            Developer developer = new Developer(
                "Ivan", 
                "Ivanov", 
                "023F65", 
                5000m, 
                "Production", 
                new List<Project>
                    {
                        new Project(
                            "Project one", 
                            DateTime.Parse("12.11.2015"), 
                            "Open", 
                            "Project one makes money!"), 
                        new Project(
                            "Project two", 
                            DateTime.Parse("2.1.2005"), 
                            "Close", 
                            "Project two makes more money")
                    });

            Manager manager = new Manager(
                "Gosho", 
                "Goshev", 
                "550215", 
                4000m, 
                "Accounting", 
                new List<Employee>
                    {
                        new Employee("Iveta", "Petkova", "B023545", 900m, "Accounting"), 
                        new Employee("Todor", "Todorov", "S03258", 850m, "Accounting")
                    });

            List<Employee> all = new List<Employee> { salesEmployee, developer, manager };

            foreach (var employee in all)
            {
                Console.WriteLine(employee);
            }

            Customer customer = new Customer("Petya", "Ivanova", "253695", 2000m);

            Console.WriteLine(customer);
        }
    }
}