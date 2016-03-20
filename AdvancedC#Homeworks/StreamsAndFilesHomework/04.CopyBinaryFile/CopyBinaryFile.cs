namespace _04.CopyBinaryFile
{
    using System.Diagnostics;
    using System.IO;

    class CopyBinaryFile
    {
        static void Main(string[] args)
        {
            string photoPath = "../../SoftUni.jpg";
            string copyPhotoPath = "../../SoftUniCopy.jpg";

            using (FileStream photo = new FileStream(photoPath,FileMode.Open))
            {
                using (FileStream fileStream = new FileStream(copyPhotoPath,FileMode.Create))
                {
                    byte[] buffer = new byte[photo.Length];
                    while (true)
                    {
                        int readBytes = photo.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }

                        fileStream.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}
