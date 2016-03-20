using System;
using System.Collections.Generic;
using System.Text;

internal class Exceptions
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if (arr.Length == 0)
        {
            throw new ArgumentException("Array can not be empty!", "arr");
        }

        if (count < 1)
        {
            throw new ArgumentOutOfRangeException("count", "Count can not be smaller than 1!");
        }

        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        if (count > str.Length)
        {
            throw new ArgumentOutOfRangeException("count", "Count cannot be bigger then string length");
        }

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }

        return result.ToString();
    }

    public static void CheckPrime(int number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException("number", "Number should be positive");
        }

        bool isPrime = true;
        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                isPrime = false;
            }
        }

        if (isPrime)
        {
            Console.WriteLine(number + " is prime!");
        }
        else
        {
            Console.WriteLine(number + " is not prime!");
        }
    }

    private static void Main()
    {
        var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = Subsequence(new[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(string.Join(" ", subarr));

        var allarr = Subsequence(new[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(string.Join(" ", allarr));

        // var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        // Console.WriteLine(String.Join(" ", emptyarr));
        Console.WriteLine(ExtractEnding("I love C#", 2));
        Console.WriteLine(ExtractEnding("Nakov", 4));
        Console.WriteLine(ExtractEnding("beer", 4));

        // Console.WriteLine(ExtractEnding("Hi", 1000));
        try
        {
            CheckPrime(23);
            CheckPrime(33);

            // CheckPrime(-5);
        }
        catch (Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }

        List<Exam> peterExams = new List<Exam>
                                    {
                                        new SimpleMathExam(2), 
                                        new CSharpExam(55), 
                                        new CSharpExam(100), 
                                        new SimpleMathExam(1), 
                                        new CSharpExam(0)
                                    };
        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}