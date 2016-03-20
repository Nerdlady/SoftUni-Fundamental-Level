namespace _07.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Phonebook
    {
        static void Main()
        {
            Dictionary<string, List<string>> phonebook = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != null)
            {
                string[] parameters = input.Split('-').ToArray();

                if (parameters[0] != "search")
                {
                    if (phonebook.ContainsKey(parameters[0]))
                    {
                        phonebook[parameters[0]].Add(parameters[1]);
                    }
                    else
                    {
                        List<string> phoneNumber = new List<string>();
                        phoneNumber.Add(parameters[1]);
                        phonebook.Add(parameters[0], phoneNumber);
                    }
                    
                }
                else
                {
                    string name = Console.ReadLine();
                    while (name != null)
                    {

                        if (phonebook.ContainsKey(name))
                        {
                            var info = phonebook.First(n => n.Key == name);
                            
                                Console.WriteLine("{0} -> {1}", info.Key, string.Join(", " , info.Value));
                        }
                        else
                        {
                            Console.WriteLine("Contact {0} does not exist.", name);
                        }

                        name = Console.ReadLine();
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
