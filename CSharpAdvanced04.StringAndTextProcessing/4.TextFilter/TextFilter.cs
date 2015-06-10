using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.TextFilter
{
    class TextFilter
    {
        static void Main()
        {
            var banWords = Console.ReadLine().Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            for (int word = 0; word < banWords.Length; word++)
            {
                int currentBanWordLength = banWords[word].Length;
                text = text.Replace(banWords[word], new string('*', currentBanWordLength));
            }
            Console.WriteLine("Output Text is:");
            Console.WriteLine(text);
        }
    }
}
