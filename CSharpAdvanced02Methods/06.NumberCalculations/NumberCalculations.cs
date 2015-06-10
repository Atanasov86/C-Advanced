using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.NumberCalculations
{
    class NumberCalculations
    {
        public static double GetMinimum (double[] numbers)
        {
            double min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
            }
            return min;
        }

        public static decimal GetMinimum(decimal[] numbers)
        {
            decimal min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
            }
            return min;
        }

        public static double GetMaximum(double[] numbers)
        {
            double max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        public static decimal GetMaximum(decimal[] numbers)
        {
            decimal max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        public static double GetAverage(double[] numbers)
        {
            double avg = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                avg += numbers[i];
            }
            avg /= numbers.Length;
            return avg;
        }

        public static decimal GetAverage(decimal[] numbers)
        {
            decimal avg = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                avg += numbers[i];
            }
            avg /= numbers.Length;
            return avg;
        }

        public static double GetSum (double[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static decimal GetSum(decimal[] numbers)
        {
            decimal sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static double GetProduct (double[] numbers)
        {
            double product = 1;
            foreach (var number in numbers)
            {
                product *= number;
            }
            return product;
        }

        public static decimal GetProduct(decimal[] numbers)
        {
            decimal product = 1m;
            foreach (var number in numbers)
            {
                product *= number;
            }
            return product;
        }
        static void Main()
        {
            double[] numbersAsDoubles = new double [] {2.23331d, 3.44d, 66.1d, 101.0d, 166.3d };
            decimal [] numbersAsDecimals = new decimal[]{2.312321312312331M, 9999999.99999M, 132.12321312M, 31.31M, 555.31313M};
            Console.Write("Minimum double element of a given set is: ");
            Console.WriteLine(GetMinimum(numbersAsDoubles));
            Console.Write("Minimum decimal element of a given set is: ");
            Console.WriteLine(GetMinimum(numbersAsDecimals));
            Console.Write("Maximum double element of a given set is: ");
            Console.WriteLine(GetMaximum(numbersAsDoubles));
            Console.Write("Maximum decimal element of a given set is: ");
            Console.WriteLine(GetMaximum(numbersAsDecimals));
            Console.Write("Average double element of a given set is: ");
            Console.WriteLine(GetAverage(numbersAsDoubles));
            Console.Write("Average decimal element of a given set is: ");
            Console.WriteLine(GetAverage(numbersAsDecimals));
            Console.Write("Sum of double elements in given set is: ");
            Console.WriteLine(GetSum(numbersAsDoubles));
            Console.Write("Sum of decimal elements in given set is: ");
            Console.WriteLine(GetSum(numbersAsDecimals));
            Console.Write("Product of double elements in given set is: ");
            Console.WriteLine(GetProduct(numbersAsDoubles));
            Console.Write("Sum of decimal elements in given set is: ");
            Console.WriteLine(GetProduct(numbersAsDecimals));
            
        }
    }
}
