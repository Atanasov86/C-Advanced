using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LastDigitOfNumber
{
    class LastDigitOfNumber
    {
        static string ReturnLastDigitAsWord(int number)
        {
            string lastDigitAsWord = String.Empty;
            int lastDigit = number % 10;
            switch (lastDigit)
            {
                case 0:
                    lastDigitAsWord = "zero";
                    break;
                case 1:
                    lastDigitAsWord = "one";
                    break;
                case 2:
                    lastDigitAsWord = "two";
                    break;
                case 3:
                    lastDigitAsWord = "three";
                    break;
                case 4:
                    lastDigitAsWord = "four";
                    break;
                case 5:
                    lastDigitAsWord = "five";
                    break;
                case 6:
                    lastDigitAsWord = "six";
                    break;
                case 7:
                    lastDigitAsWord = "seven";
                    break;
                case 8:
                    lastDigitAsWord = "eight";
                    break;
                case 9:
                    lastDigitAsWord = "nine";
                    break;
            }
            return lastDigitAsWord;
        }

        static void Main()
        {
            Console.Write("Please enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Last digit as word is: ");
            Console.WriteLine(ReturnLastDigitAsWord(num));
            Main();
        }
        
    }
}
