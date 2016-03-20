using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.Animals.Hierarchy;
namespace _02.Animals
{
    public abstract class Animal : ISoundProducible
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if(string.IsNullOrEmpty(value))
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
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age can't be negative");
                }
                this.age = value;
            }
        }

        public string Gender 
        {
            get { return this.gender; }
            set
            {
                if( value.ToLower() == "male" || value.ToLower() == "female")
                {
                    this.gender = value;
                }
                else
                {
                    throw new ArgumentException("Gender should be\"male\" or \"female\"");
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Type: {0} , Name: {1} , Age: {2} , Gender: {3}", this.GetType().Name, this.Name, this.Age, this.Gender);
        }

        public abstract void ProduceSound();
    }
}
