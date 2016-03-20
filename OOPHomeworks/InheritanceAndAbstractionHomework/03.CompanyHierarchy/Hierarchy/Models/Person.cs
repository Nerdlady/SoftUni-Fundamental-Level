namespace _03.CompanyHierarchy.Hierarchy
{
    using System;

    public class Person : IPerson
    {
        private string firstName;

        private string lastName;

        public Person(string firstName, string lastName, string id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name can't be empty");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name can't be empty");
                }

                this.lastName = value;
            }
        }

        public string Id { get; set; }

        public override string ToString()
        {
            return string.Format(
                "Type : {0}, First name: {1}, Last Name: {2}, ID: {3},", 
                this.GetType().Name, 
                this.FirstName, 
                this.LastName, 
                this.Id);
        }
    }
}