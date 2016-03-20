namespace _04.StudentClass
{
    public delegate void PropertyChangedHandler(object sender, PropertyChangedEventArgs args);

    public class Student
    {
        public event PropertyChangedHandler PropertyChange;
        private string name;
        private int age;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                var eventArgs = new PropertyChangedEventArgs("Name", this.name, value);

                var onPropertyChanged = this.PropertyChange;
                if (onPropertyChanged != null)
                {
                    onPropertyChanged("Name", eventArgs);
                }
                this.name = value;
            }

        }

        public int Age
        {
            get { return this.age; }
            set
            {
                var eventArgs = new PropertyChangedEventArgs("Age", this.age, value);

                var onPropertyChanged = this.PropertyChange;
                if (onPropertyChanged != null)
                {
                    onPropertyChanged("Age", eventArgs);
                }
                this.age = value;
            }
        }
    }
}
