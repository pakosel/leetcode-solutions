using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace StoneGameVI
{
    public class Solution
    {
        public int StoneGameVI(int[] aliceValues, int[] bobValues)
        {
            int n = aliceValues.Length;
            (int, int)[] sums = new (int, int)[n];

            for (int i = 0; i < n; i++)
                sums[i] = (aliceValues[i] + bobValues[i], i);

            Array.Sort(sums, (t1, t2) => t1.Item1.CompareTo(t2.Item1));

            int alicePts = 0;
            int bobPts = 0;
            int moves = n;
            bool aliceMove = true;
            while (moves > 0)
            {
                var idx = sums[moves - 1].Item2;
                if (aliceMove)
                    alicePts += aliceValues[idx];
                else
                    bobPts += bobValues[idx];

                moves--;
                aliceMove = !aliceMove;
            }

            if (alicePts > bobPts)
                return 1;
            else if (alicePts < bobPts)
                return -1;
            return 0;
        }
    }
}