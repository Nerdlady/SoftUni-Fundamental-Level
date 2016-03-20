using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HumanStudentWorker
{
    public abstract class Human
    {
        protected string firstName;
        protected string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; } 
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name can't bee empty");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name can't bee empty");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("Type: {0} " ,this.GetType().Name);
            output.AppendFormat("First name: {0}, " , this.FirstName);
            output.AppendFormat("Last Name: {0}, ", this.LastName);
            return output.ToString();
        }
    }
}
