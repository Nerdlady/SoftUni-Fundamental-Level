namespace _05.ValidUsername
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class ValidUsername
    {
        static void Main()
        {
            string[] usernames = Console.ReadLine().Split(new[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            Regex regex = new Regex(@"\b[a-zA-Z]\w{3,25}\b");

            List<string> validUsernames = new List<string>();

            for (int index = 0; index < usernames.Length; index++)
            {
                var isMatch = regex.IsMatch(usernames[index]);
                if (isMatch)
                {
                    var match = regex.Match(usernames[index]);
                    validUsernames.Add(match.ToString());
                }
            }


            int maxSum = 0;
            string firstUsername = string.Empty;
            string secondUsername = string.Empty;
            for (int index = 0; index < validUsernames.Count - 1; index++)
            {
                var sum = validUsernames[index].Length + validUsernames[index + 1].Length;
                if (sum > maxSum)
                {
                    maxSum = sum;
                    firstUsername = validUsernames[index];
                    secondUsername = validUsernames[index + 1];
                }
            }

            Console.WriteLine(firstUsername);
            Console.WriteLine(secondUsername);
        }
    }
}
