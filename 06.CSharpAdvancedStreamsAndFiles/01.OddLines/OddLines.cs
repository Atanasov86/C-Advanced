using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.OddLines
{
    class OddLines
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("../../text.txt");
            bool isEven = true;
            using (reader)
            {
                while (true)
                {
                    string line = reader.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    if (isEven)
                    {
                        Console.WriteLine(line);
                    }
                    isEven = !isEven;
                }
            }
        }
    }
}
