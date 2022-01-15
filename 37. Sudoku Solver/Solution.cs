using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace SudokuSolver
{
    public class Solution
    {
        public void SolveSudoku(char[][] board)
        {
            Solve(board, 0);
        }

        private bool Solve(char[][] board, int pos)
        {
            if(pos == 81)
                return true;
            var row = pos / 9;
            var col = pos % 9;
            if(board[row][col] != '.')
                return Solve(board, pos + 1);
            for(int i=1; i<10; i++)
            {
                if(!IsValid(board, row, col, i))
                    continue;
                board[row][col] = (char)('0' + i);
                if(Solve(board, pos + 1))
                    return true;
            }
            board[row][col] = '.';
            return false;
        }

        private bool IsValid(char[][] board, int row, int col, int val)
        {
            foreach(var c in board[row])
                if(c - '0' == val)
                    return false;
            for(int i=0; i<9; i++)
                if(board[i][col] - '0' == val)
                    return false;
            var sqRow = row / 3;
            var sqCol = col / 3;
            for(int i=3*sqRow; i<3*sqRow+3; i++)
                for(int j=3*sqCol; j<3*sqCol+3; j++)
                    if(board[i][j] - '0' == val)
                        return false;
            return true;
        }
    }
}