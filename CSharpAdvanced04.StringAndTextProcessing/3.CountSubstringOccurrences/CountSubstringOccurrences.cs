using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main()
        {
            string inputText = Console.ReadLine().ToLower();
            string searchingStr = Console.ReadLine();
            int count = inputText.Select((c, i) => inputText.Substring(i)).Count(sub => sub.StartsWith(searchingStr));
            Console.WriteLine(count);
            
        }
    }
}
