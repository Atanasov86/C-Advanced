using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SequenceInMatrix
{
    class SequenceInMatrix
    {
        public static int CheckingForLongestSequence(List<List<string>> list, int row, int col, string currentValue, string direction)
        {
            int currentCount = 1;
            if (direction == "horizontal")
            {
                for (int c = col; c < list[row].Count; c++)
                {
                    if ((c + 1 < list[row].Count) && (list[row][c + 1].Equals(currentValue)))
                    {
                        currentCount++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else if (direction == "vertical")
            {
                for (int r = row; r < list.Count; r++)
                {
                    if ((r + 1 < list.Count) && (list[r + 1][col].Equals(currentValue)))
                    {
                        currentCount++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else if (direction == "left diagonal")
            {
                for (int r = row, c = col; r < list.Count && c < list[row].Count; r++,c++)
                {
                    if ((r + 1 < list.Count && c + 1 < list[r + 1].Count) && (list[r + 1][c + 1].Equals(currentValue)))
                    {
                        currentCount++;
                    }
                    else
                    {
                        break;
                    }

                }
            }
            else //right diagonal
            {
                for (int r = row, c = col; r < list.Count && c < list[row].Count; r++,c++)
                {
                    if ((r - 1 >= 0 && c + 1 < list[row].Count) && (list[r - 1][c + 1].Equals(currentValue)))
                    {
                        currentCount++;
                    }
                    else
                    {
                        break;
                    }

                }
            }
            return currentCount;
        }
        static void Main()
        {
            List<List<string>> matrix = new List<List<string>>();
            string currentRow = Console.ReadLine();

            for (int row = 0; !String.IsNullOrEmpty(currentRow); row++)
            {
                string[] currentRowElements = currentRow.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                matrix.Add(new List<string>());
                for (int col = 0; col < currentRowElements.Length; col++)
                {
                    matrix[row].Add(currentRowElements[col]);
                }

                currentRow = Console.ReadLine();
            }

            int maxCount = int.MinValue;
            int currentCount = 1;
            string longestSequence = String.Empty;

            for (int row = 0; row < matrix.Count; row++)
            {
                for (int col = 0; col < matrix[row].Count; col++)
                {
                    currentCount = CheckingForLongestSequence(matrix, row, col, matrix[row][col], "vertical");
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        longestSequence = matrix[row][col];
                    }
                    currentCount = CheckingForLongestSequence(matrix, row, col, matrix[row][col], "horizontal");
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        longestSequence = matrix[row][col];
                    }
                    currentCount = CheckingForLongestSequence(matrix, row, col, matrix[row][col], "left diagonal");
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        longestSequence = matrix[row][col];
                    }
                    currentCount = CheckingForLongestSequence(matrix, row, col, matrix[row][col], "right diagonal");
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        longestSequence = matrix[row][col];
                    }
                }
            }
            Console.Write(longestSequence);
            for (int i = 1; i < maxCount; i++)
            {
                Console.Write(", {0}", longestSequence);
            }
            Console.WriteLine();
        }
    }
}
