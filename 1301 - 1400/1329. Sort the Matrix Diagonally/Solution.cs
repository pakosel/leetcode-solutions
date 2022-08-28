using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace SortTheMatrixDiagonally
{
    public class Solution
    {
        public int[][] DiagonalSort(int[][] mat)
        {
            var m = mat.Length;
            var n = mat[0].Length;
            var lst = new List<int>(Math.Max(m, n));

            for (int i = 0; i < n; i++)
                Sort(0, i);

            for (int i = 0; i < m; i++)
                Sort(i, 0);

            return mat;

            void Sort(int row, int col)
            {
                lst.Clear();
                Read(row, col);
                lst.Sort();
                Write(row, col);
            }

            void Read(int row, int col)
            {
                while (row < m && col < n)
                    lst.Add(mat[row++][col++]);
            }

            void Write(int row, int col)
            {
                int i = 0;
                while (row < m && col < n)
                    mat[row++][col++] = lst[i++];
            }
        }
    }
}