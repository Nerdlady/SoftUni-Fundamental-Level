using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HumanStudentWorker
{
    public class Student : Human
    {
        
        public string facultyNumber;
        public Student(string firstName, string lastName, string facultyNumber) 
            : base(firstName , lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber 
        {
            get { return this.facultyNumber; }
            set
            {
                if(value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("Faculty number shoud be more than 5 digits/latters and less than 10 digits/latters");
                }
                
                this.facultyNumber = value;
              
            }
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            return base.ToString() + output.AppendFormat("Faculty Number: {0}" , this.FacultyNumber, Environment.NewLine);
        }
    }
}
