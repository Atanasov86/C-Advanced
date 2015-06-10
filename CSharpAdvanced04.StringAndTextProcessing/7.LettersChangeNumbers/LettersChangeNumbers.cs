using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main()
        {
            string line = Console.ReadLine().Trim();
            List<string> letters = line.Split((char[]) null, StringSplitOptions.RemoveEmptyEntries).ToList();
            decimal sum = 0;
            for (int i = 0; i < letters.Count; i++)
            {
                char firstChar = char.Parse(letters[i].Substring(0,1));
                decimal currentNumber = decimal.Parse(letters[i].Substring(1, letters[i].Length - 2));
                char lastLetter = char.Parse(letters[i].Substring(letters[i].Length - 1));
                
                if (char.IsUpper(firstChar))
                {
                    decimal firstLetterPosition = (char)firstChar - 64;
                    sum += currentNumber/firstLetterPosition;
                }
                else
                {
                    decimal firstLetterPosition = (char)firstChar - 96;
                    sum += currentNumber*firstLetterPosition;
                }
                 
                if (char.IsUpper(lastLetter))
                {
                    decimal lastLetterPosition = (char)lastLetter - 64;
                    sum -= lastLetterPosition;
                }
                else
                {
                    decimal lastLetterPosition = (char)lastLetter - 96;
                    sum += lastLetterPosition;
                }
            }
            Console.WriteLine("{0:F2}",sum);
        }
    }
}
