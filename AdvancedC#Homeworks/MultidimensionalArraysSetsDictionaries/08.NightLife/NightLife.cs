namespace _08.NightLife
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    class NightLife
    {
        static void Main()
        {

            Dictionary<string, SortedDictionary<string, SortedSet<string>>> database =
                        new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] parameters = input.Split(';').ToArray();
                string city = parameters[0];
                string vanue = parameters[1];
                string performer = parameters[2];

                if (database.ContainsKey(city))
                {
                    if (database[city].ContainsKey(vanue))
                    {
                        if (!database[city][vanue].Contains(performer))
                        {
                            database[city][vanue].Add(performer);
                        }
                    }
                    else
                    {
                        database[city].Add(vanue, new SortedSet<string> { performer });
                    }
                }
                else
                {
                    SortedDictionary<string, SortedSet<string>> place = new SortedDictionary<string, SortedSet<string>>();
                    place.Add(vanue, new SortedSet<string> { performer });

                    database.Add(city, place);
                }
                input = Console.ReadLine();
            }

            foreach (var info in database)
            {
                Console.WriteLine(info.Key);
                foreach (var vanueInfo in info.Value)
                {
                    Console.WriteLine("->{0}: {1}", vanueInfo.Key, string.Join(", ", vanueInfo.Value));
                }

            }
        }
    }
}
