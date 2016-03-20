using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02BankOfKurtovoKonare.Interfaces;

namespace _02BankOfKurtovoKonare.Customers
{
    public class Individual : Customer ,  IIndividual
    {
        private string lastName;
        private string id;

        public Individual(string firstName, string lastName, string id)
            : base(firstName)
        {
            this.LastName = lastName;
            this.Id = id;
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Customer last name cannot be empty");
                }
                this.lastName = value;
            }
        } 
        public string Id 
        {
            get { return this.id; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Customer Id cannot be empty");
                }
                this.id = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + string.Format(", Last name: {0} , ID: {1}" , this.LastName , this.Id);
        }
    }
}
