using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _3.MatrixShuffling
{
    class MatrixShuffling
    {
        static void SwapElements(string[,] matrix, int x1, int y1, int x2, int y2)
        {
            string tempElement = String.Empty;
            tempElement = matrix[x1, y1];
            matrix[x1, y1] = matrix[x2, y2];
            matrix[x2, y2] = tempElement;
        }

        static void PrintMatrix(int rows, int cols, string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,2} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            string[,] inputMatrix = new string[rows,cols];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    inputMatrix[row, col] = Console.ReadLine();
                }
            }
            string commandLine = Console.ReadLine();
            while (commandLine != "END")
            {
                string[] commandAsArray = commandLine.Split(' ');
                if (commandAsArray[0] == "swap")
                {
                    int x1 = int.Parse(commandAsArray[1]);
                    int y1 = int.Parse(commandAsArray[2]);
                    int x2 = int.Parse(commandAsArray[3]);
                    int y2 = int.Parse(commandAsArray[4]);
                    if ((x1 >= 0 && x1 < rows) && (y1 >= 0 && y1 < cols) && (x2 >= 0 && x2 < rows) && (y2 >= 0 && y2 < cols))
                    {
                        SwapElements(inputMatrix,x1,y1,x2,y2);
                        Console.WriteLine("(after swapping {0} and {1}): ",inputMatrix[x2,y2],inputMatrix[x1,y1]);
                        PrintMatrix(rows,cols,inputMatrix);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }





                commandLine = Console.ReadLine();
            }
        }
    }
}
