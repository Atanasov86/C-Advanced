using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.FillTheMatrix
{
    class FillTheMatrix
    {
        static void FillMatrix(int[,] matrix, string direction)
        {
            int value = 1;
            if (direction == "top")
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        matrix[row, col] = value;
                        value++;
                    }
                }
            }
            else
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col % 2 == 0)
                    {
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            matrix[row, col] = value;
                            value++;
                        }
                    }
                    else
                    {
                        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                        {
                            matrix[row, col] = value;
                            value++;
                        }
                    }
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,4}", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            FillMatrix(matrix, "left");
            FillMatrix(matrix,"top");
        }
    }
}
