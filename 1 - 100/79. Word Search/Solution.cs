using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace WordSearch
{
    public class Solution
    {
        public bool Exist(char[][] board, string word)
        {
            var rows = board.Length;
            var cols = board[0].Length;

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    if (Dfs(i, j, new HashSet<(int, int)>(word.Length), 0))
                        return true;
            return false;

            bool Dfs(int r, int c, HashSet<(int, int)> visited, int pos)
            {
                if (visited.Contains((r, c)) || r < 0 || r >= rows || c < 0 || c >= cols || board[r][c] != word[pos])
                    return false;
                if (++pos == word.Length)
                    return true;
                visited.Add((r, c));
                var res = Dfs(r - 1, c, visited, pos) || Dfs(r + 1, c, visited, pos) ||
                          Dfs(r, c - 1, visited, pos) || Dfs(r, c + 1, visited, pos);
                visited.Remove((r, c));

                return res;
            }
        }
    }
}