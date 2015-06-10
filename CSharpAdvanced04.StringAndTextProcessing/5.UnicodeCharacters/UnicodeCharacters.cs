using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            string str = Console.ReadLine();
            string result = String.Empty;
            byte[] encodingBytes = Encoding.Unicode.GetBytes(str);
            for (int i = 0; i < encodingBytes.Length; i++)
            {
                byte currentByte = encodingBytes[i];
                if (currentByte != 0)
                {
                    Console.Write(@"\u{0}",currentByte.ToString("X4"));
                }
            }
            Console.WriteLine();
        }
    }
}
