using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ReverseNumber
{
    class ReverseNumber
    {
        static double ReverseNumbers (double number)
        {
            string result = number.ToString();
            char[] digits = result.ToCharArray();
            Array.Reverse(digits);
            string reversedNumber = String.Join("",digits);
            double reservedDouble = double.Parse(reversedNumber);
            return reservedDouble;
        }
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine(ReverseNumbers(number));
        }
    }
}
