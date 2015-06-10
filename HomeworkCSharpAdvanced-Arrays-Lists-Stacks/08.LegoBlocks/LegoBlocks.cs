using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LegoBlocks
{
    class LegoBlocks
    {
        static int[][] ReadJaggedArray(int n)
        {
            int[][] intArray = new int[n][];
            string[] elements;

            for (int row = 0; row < n; row++)
            {
                elements = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
                intArray[row] = Array.ConvertAll(elements, int.Parse);
            }
            return intArray;

        }

        static bool isFitting(int n, int[][] firstJaggedArray, int[][] secondJaggedArray)
        {
            bool isFit = true;
            int firstRowLength = firstJaggedArray[0].Length + secondJaggedArray[0].Length;
            for (int i = 1; i < n; i++)
            {
                int currentRowLength = firstJaggedArray[i].Length + secondJaggedArray[i].Length;
                if (firstRowLength != currentRowLength)
                {
                    isFit = false;
                    break;
                }
                firstRowLength = currentRowLength;
            }
            return isFit;
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[][] firstJaggedArray = ReadJaggedArray(n);
            int[][] secondJaggedArray = ReadJaggedArray(n);

            
            bool isFit = isFitting(n,firstJaggedArray,secondJaggedArray);

            if (isFit)
            {
                for (int i = 0; i < n; i++)
                {
                    Array.Reverse(secondJaggedArray[i]);
                    Console.WriteLine("[{0}, {1}]",string.Join(", ",firstJaggedArray[i]),string.Join(", ",secondJaggedArray[i]));
                }
            }
            else
            {
                int totalCount = 0;
                for (int i = 0; i < n; i++)
                {
                    totalCount += firstJaggedArray[i].Length + secondJaggedArray[i].Length;
                }
                Console.WriteLine("The total number of cells is: {0}",totalCount);
            }
        }
    }
}
