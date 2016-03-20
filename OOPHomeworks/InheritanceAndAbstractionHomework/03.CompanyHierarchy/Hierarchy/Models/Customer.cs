namespace _03.CompanyHierarchy.Hierarchy
{
    using System;

    public class Customer : Person, ICustomer
    {
        private decimal ammount;

        public Customer(string firstName, string lastName, string id, decimal ammount)
            : base(firstName, lastName, id)
        {
            this.Ammont = ammount;
        }

        public decimal Ammont
        {
            get
            {
                return this.ammount;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Amount of money the customer has spent cannot be negative");
                }

                this.ammount = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Money the customer has spent: {0}lv", this.Ammont);
        }
    }
}