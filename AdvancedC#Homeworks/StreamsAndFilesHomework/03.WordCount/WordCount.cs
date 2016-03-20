namespace _03.WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class WordCount
    {
        static void Main(string[] args)
        {
            string wordsPath = "../../words.txt";
            string textPath = "../../text.txt";
            string resultPath = "../../result.txt";
            List<string> words = new List<string>();
            Dictionary<string, int> toWrite = new Dictionary<string, int>();
            string text;

            using (StreamReader streamReader = new StreamReader(wordsPath))
            {
                while (!streamReader.EndOfStream)
                {
                    string[] split = streamReader.ReadLine().ToLower().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var word in split)
                    {
                        words.Add(word);
                    }
                }
            }

            using (StreamReader streamReader = new StreamReader(textPath))
            {
                text = streamReader.ReadToEnd();

                for (int index = 0; index < words.Count; index++)
                {
                    string[] splitText = text.Split(new[] { '-', '?', '!', '.', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    int count = 0;
                    for (int textIndex = 0; textIndex < splitText.Length; textIndex++)
                    {
                        var word = splitText[textIndex].ToLower();
                        if (words[index].ToLower().Equals(word))
                        {
                            count++;
                        }
                    }
                    toWrite.Add(words[index], count);
                }
            }

            using (StreamWriter streamWriter = new StreamWriter(resultPath))
            {
                var ordered = toWrite.OrderByDescending(n => n.Value);
                foreach (var line in ordered)
                {
                    streamWriter.WriteLine("{0} - {1}", line.Key,line.Value);
                }
                
            }
        }
    }
}
