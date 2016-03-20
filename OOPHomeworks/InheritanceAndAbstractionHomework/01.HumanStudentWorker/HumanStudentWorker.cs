using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HumanStudentWorker
{
    class HumanStudentWorker
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
                {
                    new Student("Ivan", "Ivanov", "s00898"),
                    new Student("Georgi", "Georgiev", "s00532"),
                    new Student("Petar", "Petrov", "s00825"),
                    new Student("Petko", "Petkov", "s02002"),
                    new Student("Mimi", "Milkova", "s00998"),
                    new Student("Stoqn", "Stoqnov", "f00785"),
                    new Student("Teodora", "Todorova", "f00300"),
                    new Student("Petya", "Dimova", "f01003"),
                    new Student("Irina", "Nikolaeva", "f00245"),
                    new Student("Boqna", "Marinova", "f00023")
                };

            var sortStudents = students.OrderBy(student => student.FacultyNumber);

            foreach (var student in sortStudents)
            {
                Console.WriteLine(student);
            }

            List<Worker> workers = new List<Worker>
            {
                    new Worker("Boris", "Georgiev", 100 , 5 ),
                    new Worker("Iveta", "Hristova", 80 , 4 ),
                    new Worker("Petko", "Petrov", 120, 8),
                    new Worker("Aneliq", "Angelova", 100 , 6 ),
                    new Worker("Sasho", "Dimitrov", 150 , 10 ),
                    new Worker("Kristian", "Borisov", 85 , 7),
                    new Worker("Liliq", "Vladimirova",  95, 9),
                    new Worker("Dobri", "Rangelov", 140, 8),
                    new Worker("Moni", "Martinova", 132, 8 ),
                    new Worker("Sara", "Simeonova", 80, 4),
                    
            };

            var sortWorkers = workers.OrderByDescending(worker => worker.MoneyPerHour(5)).ToList();

            foreach (var worker in sortWorkers)
            {
                Console.WriteLine(worker + string.Format("Money per hour: {0:F2}" , worker.MoneyPerHour(5)));
            }

            List<Human> humans = new List<Human>();
            humans.AddRange(students);
            humans.AddRange(workers);

            humans = humans.OrderBy(human => human.FirstName).ThenBy(human => human.LastName).ToList();

            foreach (var marge in humans)
            {
                Console.WriteLine(marge);
            }

        }
    }
}
