using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SlicingFile
{
    class SlicingFile
    {
        static void Slice(string sourceFile, string destinationDirectory, int parts)
        {
            FileStream stream = new FileStream(sourceFile,FileMode.Open);
            using (stream)
            {
                byte[] buffer = new byte[4096];
                var allDataFile = new List<byte>();
                while (true)
                {
                    int readBytes = stream.Read(buffer, 0, buffer.Length);
                    if (readBytes == 0)
                    {
                        break;
                    }

                    for (int i = 0; i < readBytes; i++)
                    {
                        allDataFile.Add(buffer[i]);
                    }     
                }

                int partSize = allDataFile.Count / parts;
                int leftSize = allDataFile.Count - partSize*parts;

                for (int i = 0; i < parts; i++)
                {
                    var newFilePath = destinationDirectory + "part" + i + ".txt";
                    FileStream copyFile = new FileStream(newFilePath,FileMode.Create);
                    using (copyFile)
                    {
                        if (i == parts - 1)
                        {
                            copyFile.Write(allDataFile.ToArray(), i * partSize, partSize + leftSize);
                        }
                        else
                        {
                            copyFile.Write(allDataFile.ToArray(), i * partSize , partSize);
                        }
                    }
                }
            }
        }

        static void Assemble(List<string> files, string destinationDirectory)
        {
            var allDataFIle = new List<byte>();
            for (int i = 0; i < files.Count; i++)
            {
                var sourcePath = files[i];
                FileStream partFileStream = new FileStream(sourcePath,FileMode.Open);
                using (partFileStream)
                {
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int readBytes = partFileStream.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }

                        for (int j = 0; j < readBytes; j++)
                        {
                            allDataFIle.Add(buffer[j]);
                        }
                    }
                }
            }
            FileStream copyAllPartToNewFile = new FileStream(destinationDirectory,FileMode.Create);
            using (copyAllPartToNewFile)
            {
                copyAllPartToNewFile.Write(allDataFIle.ToArray(),0,allDataFIle.Count);
            }

        }
        static void Main()
        {
            string filePath = @"../../image.jpg";
            string destinationPathDirectory = @"../../SlicedFiles/";
            int countOfParts = 5;
            Slice(filePath, destinationPathDirectory, countOfParts);
            List<string> slicedFilesPath = new List<string>()
            {
                "../../SlicedFiles/part0.txt",
                "../../SlicedFiles/part1.txt",
                "../../SlicedFiles/part2.txt",
                "../../SlicedFiles/part3.txt",
                "../../SlicedFiles/part4.txt",
            };
            Assemble(slicedFilesPath, "../../AssembledFile/AssembledFile.jpg");
        }
    }
}
