using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Customer
{
    public class Customer : ICloneable , IComparable
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string id;
        private string address;
        private string mobilePhone;
        private string email;
        private IList<Payment> payment;
        private CustomerType customerType;

        public Customer(string firstName, string middleName, string lastName, string id, string address, string mobilePhone, string email, IList<Payment> payment, CustomerType customerType)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Id = id;
            this.Address = this.address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Payment = payment;
            this.CustomerType = customerType;
        }

        public CustomerType CustomerType
        {
            get { return this.customerType; }
            private set { this.customerType = value; }
        }

        public IList<Payment> Payment
        {
            get { return this.payment; }
            private set { this.payment = value; }
        }

        public string Email
        {
            get { return this.email; }
            private set { this.email = value; }
        }

        public string MobilePhone
        {
            get { return this.mobilePhone; }
            private set { this.mobilePhone = value; }
        }

        public string Address
        {
            get { return this.address; }
            private set { this.address = value; }
        }

        public string Id
        {
            get { return this.id; }
            set
            {
                if (value == null)
                {
                    throw  new ArgumentNullException("ID cannot be negative");
                }
                this.id = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set { this.lastName = value; }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            private set { this.middleName = value; }
        }

        public string FirstName
        { 
            get { return this.firstName; }
            private set { this.firstName = value; }
        }

        public override bool Equals(object obj)
        {
            Customer customer = obj as Customer;

            if (customer == null)
            {
                return false;
            }

            if (!Object.Equals(this.FirstName, customer.FirstName))
            {
                return false;
            }

            if (!Object.Equals(this.MiddleName, customer.MiddleName))
            {
                return false;
            }

            if (!Object.Equals(this.LastName, customer.LastName))
            {
                return false;
            }

            if (this.Id != customer.Id)
            {
                return false;
            }

            
            return true;
        }

        public static bool operator ==(Customer a, Customer b)
        {
            return Customer.Equals(a, b);
        }

        public static bool operator !=(Customer a, Customer b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            Customer customer = obj as Customer;
            
            if (!Object.Equals(this.FirstName, customer.FirstName))
            {
                return this.FirstName.CompareTo(customer.FirstName);
            }
            if (!Object.Equals(this.MiddleName, customer.MiddleName))
            {
                return this.MiddleName.CompareTo(customer.MiddleName);
            }
            if (!Object.Equals(this.LastName, customer.LastName))
            {
                return this.LastName.CompareTo(customer.LastName);
            }
            if (!Object.Equals(this.Id, customer.Id))
            {
                return customer.Id.CompareTo(this.Id);
            }
            return 0;
        }

      

        public void AddPayment(params Payment[] payment)
        {
            foreach (var pmnt in payment)
            {
                this.payment.Add(pmnt);
            }
        }

        public object Clone()
        {
            var newCustomer = new Customer(
                this.firstName,
                this.middleName,
                this.lastName,
                this.id, 
                this.address, 
                this.mobilePhone, 
                this.email, 
                this.payment, 
                this.customerType);

            
            return newCustomer;
        }
 

        public override string ToString()
        {
            StringBuilder customerInfo = new StringBuilder();
            customerInfo.AppendFormat("First Name: {0}\n", this.FirstName);
            customerInfo.AppendFormat("Middle Name: {0}\n", this.MiddleName);
            customerInfo.AppendFormat("Last Name: {0}\n", this.LastName);
            customerInfo.AppendFormat("Id: {0}\n", this.Id);
            customerInfo.AppendFormat("Address: {0}\n", this.Address);
            customerInfo.AppendFormat("Mobile Phone: {0}\n", this.MobilePhone);
            customerInfo.AppendFormat("Email: {0}\n", this.Email);

            customerInfo.AppendFormat("Payments: \n");
            foreach (var pay in payment)
            {
                customerInfo.AppendFormat(pay.ToString());
            }

            customerInfo.AppendFormat("Customer Type: {0}\n", this.CustomerType);

            return customerInfo.ToString();
        }
    }
}
