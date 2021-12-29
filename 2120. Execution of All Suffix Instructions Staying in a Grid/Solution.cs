using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using Common;

namespace ExecutionOfAllSuffixInstructionsStayingInGrid
{
    public class Solution
    {
        public int[] ExecuteInstructions(int n, int[] startPos, string s)
        {
            var res = new int[s.Length];
            (int x, int y) curr = (startPos[0], startPos[1]);
            for (int i = 0; i < s.Length; i++)
            {
                curr = (startPos[0], startPos[1]);
                var p = i - 1;
                while (++p < s.Length)
                {
                    switch (s[p])
                    {
                        case 'L':
                            curr.y--;
                            break;
                        case 'R':
                            curr.y++;
                            break;
                        case 'U':
                            curr.x--;
                            break;
                        case 'D':
                            curr.x++;
                            break;
                    }
                    if (curr.x < 0 || curr.x == n || curr.y < 0 || curr.y == n)
                        break;
                    else
                        res[i]++;
                }
            }
            return res;
        }
    }
}