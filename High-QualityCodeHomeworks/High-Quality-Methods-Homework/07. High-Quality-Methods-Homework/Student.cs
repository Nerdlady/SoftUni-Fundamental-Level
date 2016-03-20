namespace Methods
{
    using System;
    using System.Linq;

    /// <summary>
    ///   The student class.
    /// </summary>
    internal class Student
    {
        private string firstName;

        private string lastName;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be empty.");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be empty.");
                }

                this.lastName = value;
            }
        }

        public string Info { get; set; }

        /// <summary>
        ///   Check if the student is older then another student.
        /// </summary>
        /// <param name="other">The other student</param>
        /// <returns>True or false.</returns>
        public bool IsOlderThan(Student other)
        {
            try
            {
                DateTime thisStudentDateOfBirth = this.GetDateOfBirth(this.Info);
                DateTime otherStudentDateOfBirth = other.GetDateOfBirth(other.Info);
                return thisStudentDateOfBirth < otherStudentDateOfBirth;
            }
            catch (Exception)
            {
                throw new ArgumentException("Invalid date of birth");
            }
        }

        /// <summary>
        ///   Split Info and gets the date of birth.
        /// </summary>
        /// <param name="info">Info about student.</param>
        /// <returns>Date of birth.</returns>
        public DateTime GetDateOfBirth(string info)
        {
            string[] paramArgs = info.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            string dateInfo = paramArgs.Last().Substring(8).Trim();

            DateTime date = DateTime.Parse(dateInfo);

            return date;
        }
    }
}