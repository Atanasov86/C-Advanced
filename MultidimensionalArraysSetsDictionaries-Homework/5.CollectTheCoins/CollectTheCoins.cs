using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.CollectTheCoins
{
    class CollectTheCoins
    {
        static void Main()
        {
            List<List<char>> board = new List<List<char>>();
            List<char> movementCommands = new List<char>();
            char coins = '$';
            for (int row = 0; row < 4; row++)
            {
                string currentString = Console.ReadLine();
                board.Add(new List<char>());
                for (int ch = 0; ch < currentString.Length; ch++)
                {
                    board[row].Add(currentString[ch]);
                }
            }

            string movementString = Console.ReadLine();
            for (int ch = 0; ch < movementString.Length; ch++)
            {
                movementCommands.Add(movementString[ch]);
            }

            int startingRow = 0;
            int startingCol = 0;
            int countCollectedCoins = 0;
            int countWallHits = 0;
            for (int i = 0; i < movementCommands.Count; i++)
            {
                int currentRow = startingRow;
                int currentCol = startingCol;
                char currentMove = movementCommands[i];
                switch (currentMove)
                {
                    case '^':
                        currentRow -= 1;
                        break;
                    case'V':
                        currentRow += 1;
                        break;
                    case '>':
                        currentCol += 1;
                        break;
                    case '<':
                        currentCol -= 1;
                        break;
                }
                if (currentRow < 0 || currentRow > board.Count)
                {
                    countWallHits++;
                    currentRow = startingRow;
                    currentCol = startingCol;
                    
                }

                if (currentCol < 0 || currentCol > board[currentRow].Count)
                {
                    countWallHits++;
                    currentCol = startingCol;
                    currentRow = startingRow;
                }

                if (board[currentRow][currentCol].Equals(coins))
                {
                    countCollectedCoins++;
                }

                startingRow = currentRow;
                startingCol = currentCol;
            }
            Console.WriteLine("Coins collected: {0}",countCollectedCoins);
            Console.WriteLine("Walls hit: {0}",countWallHits);
            
        }
    }
}
