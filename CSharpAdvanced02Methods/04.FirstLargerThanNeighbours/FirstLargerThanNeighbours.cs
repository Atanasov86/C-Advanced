using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
    {
        static int GetIndexOfFirstLargerElementThanNeighbours (int[] array)
        {
            
            int index = 0;
            for (int position = 0; position < array.Length; position++)
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

                if (isLarger)
                {
                    index = position;
                    break;
                }
                else
                {
                    index = -1;
                }
            }
            return index;
        }
        static void Main()
        {
            int[] firstSequence = new int[] {1, 3, 4, 5, 1, 0, 5};
            int[] secondSequence = new int[] {1, 2, 3, 4, 5, 6, 6};
            int[] thirdSequence = new int[] {1, 1, 1};
            Console.WriteLine(GetIndexOfFirstLargerElementThanNeighbours(firstSequence));
            Console.WriteLine(GetIndexOfFirstLargerElementThanNeighbours(secondSequence));
            Console.WriteLine(GetIndexOfFirstLargerElementThanNeighbours(thirdSequence));
        }
    }
}
