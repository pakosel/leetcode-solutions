using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace LuckyNumbersInMatrix
{
    public class Solution
    {
        public IList<int> LuckyNumbers(int[][] matrix)
        {
            var res = new List<int>();
            foreach (var row in matrix)
            {
                var minIdx = FindMinIdx(row);
                if (IsMaxInCol(minIdx, row[minIdx]))
                    res.Add(row[minIdx]);
            }
            return res;

            int FindMinIdx(int[] row)
            {
                var res = 0;
                for (int i = 1; i < row.Length; i++)
                    if (row[i] < row[res])
                        res = i;
                return res;
            }

            bool IsMaxInCol(int colIdx, int max)
            {
                for (int i = 0; i < matrix.Length; i++)
                    if (matrix[i][colIdx] > max)
                        return false;
                return true;
            }
        }
    }
}