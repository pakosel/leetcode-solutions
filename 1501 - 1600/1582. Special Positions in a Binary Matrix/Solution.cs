using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace SpecialPositionsInBinaryMatrix
{
    public class Solution
    {
        public int NumSpecial(int[][] mat)
        {
            var invalidRows = new HashSet<int>();
            var res = 0;

            for (int r = 0; r < mat.Length; r++)
                if (mat[r].Count(e => e == 1) != 1)
                    invalidRows.Add(r);
            for (int c = 0; c < mat[0].Length; c++)
            {
                int row = -1;
                int r = 0;
                for (r = 0; r < mat.Length; r++)
                    if (mat[r][c] == 1)
                        if (row == -1 && !invalidRows.Contains(r))
                            row = r;
                        else
                            break;
                if (row != -1 && r == mat.Length)
                    res++;
            }
            return res;
        }
    }

}