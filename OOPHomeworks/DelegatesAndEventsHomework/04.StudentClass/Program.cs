﻿using System;


namespace _04.StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Peter", 22);
            student.PropertyChange += (sender, eventArgs) =>
            {
                Console.WriteLine("Property changed: {0} (from {1} to {2})",
                    eventArgs.PropName, eventArgs.OldValue, eventArgs.NewValue);
            };
            student.Name = "Maria";
            student.Age = 19;

            

        }
    }
}
