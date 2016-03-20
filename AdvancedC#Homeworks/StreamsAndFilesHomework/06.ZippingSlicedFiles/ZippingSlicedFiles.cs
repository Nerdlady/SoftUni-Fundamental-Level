namespace _06.ZippingSlicedFiles
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.IO.Compression;

    class ZippingSlicedFiles
    {
        static List<string> files = new List<string>();

        private static string extension;
        static void Main(string[] args)
        {
            string path = "../../SoftUni.jpg";
            int numberofParts = 4;

            string folderPath = @"../../";
            Slice(path, folderPath, numberofParts);
            Assemble(files, folderPath);
            files.Clear();
            string textPath = "../../text.txt";
            Slice(textPath, folderPath, 2);
            Assemble(files, folderPath);


        }

        static void Slice(string sourceFile, string destinationDirectory, int parts)
        {
            using (FileStream file = new FileStream(sourceFile, FileMode.Open))
            {
                long sizeOfEachFile = (long)Math.Ceiling((double)file.Length / parts);

                for (int i = 0; i < parts; i++)
                {
                    string baseFileName = Path.GetFileNameWithoutExtension(sourceFile);
                    extension = Path.GetExtension(sourceFile);

                    string fileName = destinationDirectory + baseFileName + i + extension;
                    files.Add(fileName);

                    int byteCounter = 0;

                    using (FileStream outputFile = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                    {
                        using (var compressionStream = new GZipStream(outputFile, CompressionMode.Compress,false))
                        {
                            byte[] buffer = new byte[4096];
                            while (byteCounter <= sizeOfEachFile)
                            {
                                int readedByte = file.Read(buffer, 0, buffer.Length);
                                if (readedByte == 0)
                                {
                                    break;
                                }

                                compressionStream.Write(buffer, 0, readedByte);
                                byteCounter += readedByte;
                            }
                        }

                    }
                }
            }
        }

        private static void Assemble(List<string> files, string destinationDirectory)
        {
            string fileOutputPath = destinationDirectory + "assembled" + extension;

            using (FileStream fileStream = new FileStream(fileOutputPath, FileMode.Append))
            {
                foreach (var filePart in files)
                {
                    using (FileStream partSource = new FileStream(filePart, FileMode.Open))
                    {
                        using (var compressionStream = new GZipStream(partSource, CompressionMode.Decompress, false))
                        {
                            Byte[] bytePart = new byte[4096];
                            while (true)
                            {
                                int readBytes = compressionStream.Read(bytePart, 0, bytePart.Length);
                                if (readBytes == 0)
                                {
                                    break;
                                }

                                fileStream.Write(bytePart, 0, readBytes);
                            }
                        }
                    }
                }
            }

        }
    }
}
