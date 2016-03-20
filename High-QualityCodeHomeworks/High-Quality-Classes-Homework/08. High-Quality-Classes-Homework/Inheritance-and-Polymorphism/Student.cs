namespace InheritanceAndPolymorphism
{
    using System;

    public class Student
    {
        private string name;

        public Student(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Student name cannot be empty.");
                }

                this.name = value;
            }
        }

        public override string ToString()
        {
            return string.Format(this.Name);
        }
    }
}