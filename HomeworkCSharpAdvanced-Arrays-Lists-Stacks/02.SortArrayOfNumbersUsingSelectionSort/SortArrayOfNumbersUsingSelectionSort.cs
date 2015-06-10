using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortArrayOfNumbersUsingSelectionSort
{
    static void Main()
    {
        List<string> input = Console.ReadLine().Split(' ').ToList();
        List<int> numbers = new List<int>();
        numbers = input.ConvertAll(s => int.Parse(s));
        bool isSwap = false;
        do
        {
            isSwap = false;
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                int leftPos = i;
                int rightPos = i + 1;
                if (numbers[leftPos] > numbers[rightPos])
                {
                    int tempElement = numbers[leftPos];
                    numbers[leftPos] = numbers[rightPos];
                    numbers[rightPos] = tempElement;
                    isSwap = true;
                }
            }

        } while (isSwap);
        Console.WriteLine(string.Join(" ",numbers));
    }
}

