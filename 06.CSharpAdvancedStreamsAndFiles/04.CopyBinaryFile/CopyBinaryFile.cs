using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CopyBinaryFile
{
    class CopyBinaryFile
    {
        static void Main()
        {
            FileStream inputStream = new FileStream("../../images.jpg",FileMode.Open);
            FileStream outputStream = new FileStream("../../newfile.txt",FileMode.Create);
            using (inputStream)
            {
                using (outputStream)
                {
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int readBytes = inputStream.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }
                        outputStream.Write(buffer,0,readBytes);
                    }
                }
            }
        }
    }
}
