using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LineNumbers
{
    class LineNumbers
    {
        static void Main()
        {
            StreamReader fileReader = new StreamReader("../../text.txt");
            StreamWriter fileWriter = new StreamWriter("../../newText.txt");
            using (fileReader)
            {
                using (fileWriter)
                {
                    int countLine = 0;
                    while (true)
                    {
                        string line = fileReader.ReadLine();
                        if (line == "")
                        {
                            break;
                        }
                        fileWriter.WriteLine("{0, -5} {1}",countLine,line);
                        countLine++;
                    }

                }
            }
        }
    }
}
