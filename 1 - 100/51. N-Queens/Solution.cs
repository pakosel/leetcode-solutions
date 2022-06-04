using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;

namespace NQueens
{
    public class Solution
    {        
        public IList<IList<string>> SolveNQueens(int n)
        {
            const int EMPTY = 0;
            const int QUEEN = -1;

            var arr = Enumerable.Range(0, n).Select(_ => new int[n]).ToArray();
            var res = new List<IList<string>>();

            Check(0);

            return res;

            void Check(int checkRow)
            {
                for(int i=0; i<n; i++)
                    if(arr[checkRow][i] == EMPTY)   //we can put Queen here
                    {
                        BlockUnblock(checkRow, i, 1);
                        if(checkRow < n-1)
                            Check(checkRow+1);
                        else
                            SaveResult();
                        BlockUnblock(checkRow, i, -1);
                    }
            }

            void BlockUnblock(int row, int col, int val)
            {
                foreach(var r in new int[] {-1, 0, 1})
                    foreach(var c in new int[] {-1, 0, 1})
                        if(r != 0 || c != 0)
                            Mark(row, col, (r, c), val);
                
                arr[row][col] = (val > 0 ? QUEEN : EMPTY);     //put Queen or remove it
            }

            void Mark(int row, int col, (int r, int c) inc, int val)
            {
                row += inc.r;
                col += inc.c;
                while(row >= 0 && row < n && col >= 0 && col < n)
                {
                    if(arr[row][col] != QUEEN)      //don't mark cells with Queen
                        arr[row][col] += val;
                    row += inc.r;
                    col += inc.c;
                }
            }

            void SaveResult() => 
                res.Add(arr.Select(r => string.Join("", r.Select(c => c < 0 ? 'Q' : '.'))).ToList());
        }
    }
}