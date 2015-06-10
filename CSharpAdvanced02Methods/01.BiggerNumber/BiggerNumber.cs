using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BiggerNumber
{
    class BiggerNumber
    {

        static int GetMax(int a, int b)
        {
            int max = int.MinValue;
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            return max;
        }

        static void Main()
        {
            Console.Write("Enter first num: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter second num: ");
            int secondNum = int.Parse(Console.ReadLine());
            Console.Write("The larger num is: ");
            Console.WriteLine(GetMax(firstNum,secondNum));
        }
    }
}
