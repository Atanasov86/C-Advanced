using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _06.Count_Symbols
{
    class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            SortedDictionary<char, int> dictionary = new SortedDictionary<char, int>();

            while (input.Length > 0)
            {
                var firstChar = input[0];
                var count = input.Where(ch => ch == firstChar).Count();
                dictionary[firstChar] = count;
                input = input.Where(ch => ch != firstChar).ToArray();
            }

            foreach (var entry in dictionary)
            {
                Console.WriteLine("{0}: {1} time/s", entry.Key, entry.Value);
            }
        }
    }
}
