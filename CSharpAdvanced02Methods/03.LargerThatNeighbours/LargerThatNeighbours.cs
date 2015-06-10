using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LargerThatNeighbours
{
    class LargerThatNeighbours
    {
        static bool IsLargerThanNeighbours(int[] array, int position)
        {
            bool isLarger = false;
            if (position == 0)
            {
                isLarger = array[position] > array[position + 1];
            }
            else if (position == array.Length - 1)
            {
                isLarger = array[position] > array[position - 1];
            }
            else
            {
                isLarger = array[position] > array[position + 1] && array[position] > array[position - 1];
            }
            return isLarger;
        }

        static void Main()
        {
            int[] numbers = new int[] {1, 3, 4, 5, 1, 0, 5};
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(IsLargerThanNeighbours(numbers, i));
            }
        }
    }
}
