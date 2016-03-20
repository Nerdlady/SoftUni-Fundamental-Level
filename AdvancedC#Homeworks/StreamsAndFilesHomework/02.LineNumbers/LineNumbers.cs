namespace _02.LineNumbers
{
    using System.IO;

    class LineNumbers
    {
        static void Main(string[] args)
        {
            string pathToRead = "../../LineNumbersRead.txt";
            string pathToWrite = "../../LineNumbersWrite.txt";

            int lineNumber = 1;
            using (StreamReader streamReader = new StreamReader(pathToRead))
            {
                using (StreamWriter streamWriter = new StreamWriter(pathToWrite))
                {
                    
                    while (!streamReader.EndOfStream)
                    {
                        string readLine = streamReader.ReadLine();
                        streamWriter.WriteLine("{0}.{1}" ,lineNumber , readLine);
                        lineNumber++;
                    }
                   
                }
            }
        }
    }
}
