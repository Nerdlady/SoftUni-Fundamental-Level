namespace _03.CompanyHierarchy.Hierarchy
{
    using System;

    using _03.CompanyHierarchy.Hierarchy.Interfaces;

    public class Sale : ISale
    {
        private decimal price;

        private string productName;

        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName
        {
            get
            {
                return this.productName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Product name cannot be empty");
                }

                this.productName = value;
            }
        }

        public DateTime Date { get; set; }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Product price cannpt be negative");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            return string.Format(
                "Product name: {0}, Product date: {1}, Product price: {2}lv", 
                this.ProductName, 
                this.Date, 
                this.Price);
        }
    }
}