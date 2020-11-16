using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace LongestMountainInArray
{
    public class Solution
    {
        public int LongestMountain(int[] A)
        {
            int prevState = 0;
            int begin = -1;
            int max = 0;
            for (int i = 1; i < A.Length; i++)
            {
                int state = A[i] - A[i - 1];

                if (state > 0 && prevState <= 0)
                    begin = i - 1;
                else if (state < 0 && prevState != 0 && begin != -1)
                    max = Math.Max(max, i - begin + 1);
                else if (state == 0)
                    begin = -1;

                prevState = state;
            }

            return max;
        }
    }
}