using System.Collections.Generic;
using System.Linq;
using System;

namespace GameOfLife
{
    public class Solution
    {
        public void GameOfLife(int[][] board)
        {
            for (int i = 0; i < board.Length; i++)
                for (int j = 0; j < board[0].Length; j++)
                {
                    var cnt = Count(board, i, j);

                    if (board[i][j] == 0 && cnt == 3)
                        board[i][j] = 2;
                    if (board[i][j] == 1 && (cnt < 2 || cnt > 3))
                        board[i][j] = 10;
                }

            for (int i = 0; i < board.Length; i++)
                for (int j = 0; j < board[0].Length; j++)
                    if (board[i][j] == 2)
                        board[i][j] = 1;
                    else if (board[i][j] == 10)
                        board[i][j] = 0;
        }

        /*
            0 -> 0  or 2
            1 -> 10 or 1
        */
        private int Count(int[][] board, int x, int y)
        {
            var res = 0;
            for (int i = x - 1; i <= x + 1; i++)
                for (int j = y - 1; j <= y + 1; j++)
                    if ((i == x && j == y) || i < 0 || j < 0
                       || i > board.Length - 1 || j > board[0].Length - 1)
                        continue;
                    else if (board[i][j] == 1 || board[i][j] == 10)
                        res++;
            return res;
        }
    }
}