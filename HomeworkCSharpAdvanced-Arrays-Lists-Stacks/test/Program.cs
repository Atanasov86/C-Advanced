using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Arr_Using_Selection_Sort
{
    class Program
    {
        static int[] numbers;

        static void LINQSort()
        {
            var newArray = from n in numbers
                           orderby n
                           select n;

            foreach (var num in newArray)
            {
                Console.Write(num + " ");
            }
        }
        static int[] SelectionSort()
        {
            for (int a = 0; a < numbers.Length - 1; a++)
            {
                int minValue = a;
                for (int b = a + 1; b < numbers.Length; b++)
                {
                    if (numbers[b] < numbers[minValue])
                    {
                        minValue = b;
                    }
                }
                int temp = numbers[a];
                numbers[a] = numbers[minValue];
                numbers[minValue] = temp;
            }
            return numbers;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            numbers = input.Split().Select(int.Parse).ToArray();

            Console.WriteLine("LINQ");
            LINQSort();
            Console.WriteLine();
            Console.WriteLine("Seltection Sort");
            SelectionSort();
            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
