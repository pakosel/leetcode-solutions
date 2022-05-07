using System.Collections.Generic;
using System.Linq;
using System;

namespace SpiralMatrixII
{
    public class Solution
    {
        int refsteps = 0;
        public int[][] GenerateMatrix(int n)
        {
            refsteps = n;
            int cnt = n * n;
            int[][] res = new int[n][];
            for (int r = 0; r < n; r++)
                res[r] = new int[n];

            int x = 0;
            int y = 0;
            int dir = 0; //0 = right, 1 = down, 2 = left, 3 = up
            int steps = n - 1;

            int i = 1;
            while (i <= cnt)
            {
                res[x][y] = i;
                Increment(ref x, ref y, ref dir, ref steps);

                i++;
            }

            return res;
        }

        private void Increment(ref int x, ref int y, ref int dir, ref int steps)
        {
            switch (dir)
            {
                case 0:
                    y += 1;
                    break;
                case 1:
                    x += 1;
                    break;
                case 2:
                    y -= 1;
                    break;
                case 3:
                    x -= 1;
                    break;
            }
            if (--steps == 0)
            {
                if (dir == 0 || dir == 2)
                    refsteps--;
                steps = refsteps;
                dir = (dir + 1) % 4;
            }
        }
    }
}