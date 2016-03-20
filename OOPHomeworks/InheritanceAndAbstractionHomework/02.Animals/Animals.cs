
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.Animals.Hierarchy;

namespace _02.Animals
{
    class Animals
    {
        static void Main(string[] args)
        {
            Kitten pipi = new Kitten("Pipi", 8);
            Tomcat momo = new Tomcat("Momo", 5);
            Cat chocho = new Cat("Chocho", 11, "Male");
            Cat puhi = new Cat("Puhi", 3, "Female");

            List<Cat> cats = new List<Cat>
            {
                pipi,
                momo,
                chocho,
                puhi
            };

            foreach (var cat in cats)
            {
                Console.Write(cat + " , Says: ");
                cat.ProduceSound();
            }
            Dog sharo = new Dog("Sharo", 9, "Male");
            Dog loki = new Dog("Loki", 2, "Male");
            Dog shaila = new Dog("Shaila", 7, "Female");

            List<Dog> dogs = new List<Dog>
            {
                sharo,
                loki,
                shaila
            };
            foreach (var dog in dogs)
            {
                Console.Write(dog + " , Says: ");
                dog.ProduceSound();
            }

            Frog frogy = new Frog("Frogy", 2, "Male");
            Frog greeny = new Frog("Greeny", 6, "Female");
            Frog doty = new Frog("Doty", 1, "Female");

            List<Frog> frogs = new List<Frog>
            {
                frogy,
                greeny,
                doty
            };

            foreach (var frog in frogs)
            {
                Console.Write(frog + " , Says: ");
                frog.ProduceSound();
            }

            List<Animal> averageAge = new List<Animal>
            {
                pipi,
                momo,
                chocho,
                puhi,
                sharo,
                loki,
                shaila,
                frogy,
                greeny,
                doty
            };

            var aveAge =
                from average in averageAge
                group average by new { Group = average.GetType().Name } into grouped
                select new
                {
                    Group = grouped.Key.Group,
                    AverageAge = grouped.Average(a => a.Age)
                };

            foreach (var animal in aveAge)
            {
                Console.WriteLine(animal);
            }


        }

    }
}
