using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.ReplaceATag
{
    class ReplaceATag
    {
        static void Main()
        {
            string tag = "<ul><li><a href=http://softuni.bg>SoftUni</a></li></ul>";
            string[] patterns = new[] { "<a", @"<\/a>", @"(?<=\.bg)." };
            //@"(?<open><a)|(?<close><\/a>)|(?<=\.bg).";
            string[] replacements = new[] {"[URL", "[/URL]", "]"};
            for (int i = 0; i < patterns.Length; i++)
            {
                string currentPattern = String.Format("{0}", patterns[i]);
                string currentReplacement = String.Format("{0}", replacements[i]);
                Regex regex = new Regex(currentPattern);
                tag = regex.Replace(tag, currentReplacement);
            }
            Console.WriteLine(tag);
        }
    }
}
