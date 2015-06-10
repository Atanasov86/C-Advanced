using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1.SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main()
        {
            string text = Console.ReadLine();
            List<string> myList = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                string currentChar = text[i].ToString();
                if (!myList.Contains(currentChar))
                {
                    myList.Add(currentChar);
                }
            }
            
            foreach (var item in myList)
            {
                string pattern = string.Format("{0}+", item);
                string replace = string.Format("{0}", item);
                Regex rgx = new Regex(pattern);
                text = rgx.Replace(text, replace);
            }
            Console.WriteLine(text);
        }
    }
}
