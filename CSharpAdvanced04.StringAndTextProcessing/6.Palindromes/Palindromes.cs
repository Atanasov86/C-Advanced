using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Palindromes
{
    class Palindromes
    {
        static string ReverseString(string str)
        {
            return new string(str.Reverse().ToArray());
        }

        private static void Main()
        {
            string[] text = Console.ReadLine()
                .Split(new char[] {' ', '?', ',', '.', '!'}, StringSplitOptions.RemoveEmptyEntries);
            List<string> polindromesList = new List<string>();            
            for (int i = 0; i < text.Length; i++)
            {
                string currentString = text[i];
                string currentReversedString = ReverseString(currentString);
                if (currentString.Equals(currentReversedString))
                {
                    polindromesList.Add(currentString);
                }
            }
            polindromesList.Sort();
            Console.WriteLine(string.Join(", ",polindromesList));
        }
    }
}
