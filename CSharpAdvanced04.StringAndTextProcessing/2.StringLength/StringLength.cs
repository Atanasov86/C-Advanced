using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.StringLength
{
    class StringLength
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int stringLength = input.Length;
            StringBuilder sb = new StringBuilder(input);
            if (stringLength <= 20)
            {
                for (int i = stringLength; i < 20; i++)
                {
                    sb.Append('*', 1);
                }
                Console.WriteLine(sb);
            }
            else
            {
                string result = input.Substring(0,20);
                Console.WriteLine(result);
            }
        }
    }
}
