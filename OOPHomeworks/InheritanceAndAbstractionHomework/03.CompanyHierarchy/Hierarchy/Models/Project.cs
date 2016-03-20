namespace _03.CompanyHierarchy.Hierarchy
{
    using System;

    using _03.CompanyHierarchy.Hierarchy.Interfaces;

    public class Project : IProject
    {
        private string projectName;

        private string state;

        public Project(string projectName, DateTime projectDate, string state, string projectDetails = null)
        {
            this.ProjectName = projectName;
            this.ProjectDate = this.ProjectDate;
            this.ProjectDetails = projectDetails;
            this.State = state;
        }

        public string ProjectName
        {
            get
            {
                return this.projectName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Project name cannot be empty");
                }

                this.projectName = value;
            }
        }

        public DateTime ProjectDate { get; set; }

        public string ProjectDetails { get; set; }

        public string State
        {
            get
            {
                return this.state;
            }

            set
            {
                switch (value.ToLower())
                {
                    case "open":
                    case "close":
                        this.state = value;
                        break;
                    default:
                        throw new ArgumentException("Project state should be open or close");
                }
            }
        }

        public void CloseProject()
        {
            this.State = "close";
        }

        public override string ToString()
        {
            return string.Format(
                "Project name: {0}, Project date: {1}, Project State: {2}, Project details: {3}", 
                this.projectName, 
                this.ProjectDate, 
                this.State, 
                this.ProjectDetails);
        }
    }
}