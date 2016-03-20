using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Persons
{
    public class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }
        public Person(string name, int age)
            : this(name, age, "")
        {
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can't be empty");
                }
                this.name = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Age shoud be in range [1...100]");
                }
                this.age = value;
            }
        }
        public string Email
        {
            get { return this.email; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    this.email = "-";
                }
                else if (value.Contains('@'))
                {
                    this.email = value;
                }
                else
                {
                    throw new ArgumentException("Incorret email format");
                }
            }
        }


        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1} , Email: {2}", this.name, this.age, this.email);
        }
    }
}
