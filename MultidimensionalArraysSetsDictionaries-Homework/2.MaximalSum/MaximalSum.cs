using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MaximalSum
{
    class MaximalSum
    {
        static void FillMatrix(int rows, int cols, int[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                int[] rowNumbers = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowNumbers[col];
                }
            }
        }
        static void MaximalSumOfMatrix3x3(int[,] matrix)
        {
            int maxSum = Int32.MinValue;
            int startingBestRow = 0;
            int startingBestCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                              matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                              matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        startingBestRow = row;
                        startingBestCol = col;
                    }
                }
            }
            Console.WriteLine("Sum = {0}",maxSum);
            for (int row = startingBestRow; row < startingBestRow + 3; row++)
            {
                for (int col = startingBestCol; col < startingBestCol + 3; col++)
                {
                    Console.Write("{0,4}",matrix[row,col]);
                }
                Console.WriteLine();
            }
            
        }
        static void Main()
        {
            string inputRowsCols = Console.ReadLine();
            int rows = int.Parse(inputRowsCols[0].ToString());
            int cols = int.Parse(inputRowsCols[2].ToString());
            int[,] matrix = new int[rows,cols];
            //fill the matrix
            FillMatrix(rows, cols, matrix);
            MaximalSumOfMatrix3x3(matrix);
        }

        
    }
}
