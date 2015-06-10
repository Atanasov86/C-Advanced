using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.SentenceExtractor
{
    class SentenceExtractor
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            string pattern = string.Format(@"(?<=\s|^)(.*?\b{0}\b.*?(?=\!|\.|\?)[?.!])", word);
            Regex rgx = new Regex(pattern);
            MatchCollection matches = rgx.Matches(text);
            foreach (var item in matches)
            {
                Console.WriteLine(item);
            }
        }
    }
}
