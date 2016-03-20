namespace _01.OddLines
{
    using System;
    using System.IO;

    class OddLines
    {
        static void Main(string[] args)
        {
            string path = "../../OddLines.txt";

            using (StreamReader streamReader = new StreamReader(path))
            {
                int line = 0;
                while (!streamReader.EndOfStream)
                {
                    if (line % 2 == 0)
                    {
                        string readLine = streamReader.ReadLine();
                         Console.WriteLine(readLine);
                    }
                    line++;
                }
            }
        }
    }
}
