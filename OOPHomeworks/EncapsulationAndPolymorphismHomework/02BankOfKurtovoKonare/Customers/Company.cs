using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02BankOfKurtovoKonare.Interfaces;

namespace _02BankOfKurtovoKonare.Customers
{
    public class Company : Customer , ICompany
    {
        private string companyEntity;
        public Company(string companyName, string companyEntity)
            : base(companyName)
        {
            this.CompanyEntity = companyEntity;
        }

        public string CompanyEntity 
        {
            get { return this.companyEntity; } 
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Company entity cannot be null");
                }
                this.companyEntity = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Company Entity: {0}" , this.CompanyEntity);
        }
    }
}
