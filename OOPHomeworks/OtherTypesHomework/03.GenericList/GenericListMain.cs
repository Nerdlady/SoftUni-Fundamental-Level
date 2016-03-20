using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _03.GenericList
{
    class GenericListMain
    {
        static void Main(string[] args)
        {
            GenericList<int> numbers = new GenericList<int>();
            numbers.Add(3);
            numbers.Add(5);
            numbers.Add(15);
            numbers.Add(45);
            numbers.Add(67);

            Console.WriteLine("List: " + numbers);
            numbers.InsertElementAt(100, 3);
            Console.WriteLine("List after InsertElementAt: " + numbers);
            numbers.RemoveElementAtIndex(4);
            Console.WriteLine("List after RemoveElementAtIndex: " + numbers);
            Console.WriteLine("Element at index - 2: " + numbers.ElementAtIndex(2));
            Console.WriteLine("Index of element - 100: " + numbers.IndexOf(100));
            Console.WriteLine("Contains - 3: " + numbers.Contains(3));
            Console.WriteLine("Min: " + numbers.Min());
            Console.WriteLine("Max: " + numbers.Max());
            Console.WriteLine();

            GenericList<string> names = new GenericList<string>();
            names.Add("Pesho");
            names.Add("Gosho");
            names.Add("Ivan");

            Console.WriteLine("List: " + names);
            names.InsertElementAt("Mariika", 3);
            Console.WriteLine("List after InsertElementAt: " + names);
            names.RemoveElementAtIndex(2);
            Console.WriteLine("List after RemoveElementAtIndex: " + names);
            Console.WriteLine("Element at index - 2: " + names.ElementAtIndex(2));
            Console.WriteLine("Index of element - Pesho: " + names.IndexOf("Pesho"));
            Console.WriteLine("Contains - Ivan: " + names.Contains("Ivan"));
            Console.WriteLine();

            Console.WriteLine(names.Version());


            
        }
    }
}
